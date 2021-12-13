using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ScraperLibrary
{
    public class Processor : IHtmlGetter
    {
        public string? url;
        public string? name;
        public double price;
        public string? socket;

        public override string ToString() {
            return name;
        }
        //get page html string by url
        public virtual string getHtml(string url)
        {
            try
            {
                var CpuHttpClient = new HttpClient();
                var html = Task.Run(() => CpuHttpClient.GetStringAsync(url)).Result;
                return html;
            }
            catch (Exception)//if cannot connect
            {
                return "Error";
            }
        }
        //Scraping CPU listings
        public async Task<List<Processor>> GetHtmlAsync()
        {
            List<Processor> processors = new List<Processor>();
            
            var cpuUrl1 = "https://www.1a.lt/c/kompiuteriu-komponentai-tinklo-produktai/komponentai/procesoriai/2vf?page=";
            var cpuPage = 1;
            var cpuUrl2 = "&page_per=72";
            var CpuHtmlDocument = new HtmlDocument();
            Processor p = new Processor();

            while (true)
            {
                //creating url for every page
                var cpuUrl = cpuUrl1 + cpuPage.ToString() + cpuUrl2;

                var cpuHtml = p.getHtml(cpuUrl);

                if(cpuHtml == "Error")//exit writing to list if cannot connect or everything has been scraped
                {
                    break;
                }
                else
                {
                    CpuHtmlDocument.LoadHtml(cpuHtml);

                    var cpuList = CpuHtmlDocument.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("catalog-taxons-product catalog-taxons-product--grid-view")).ToList();

                    foreach (var i in cpuList)
                    {
                        //link
                        var link = "https://www.1a.lt" + i.Descendants("a").FirstOrDefault().GetAttributeValue("href", "");
                        //name
                        var name = i.Descendants("div").FirstOrDefault().GetAttributeValue("data-name", "");
                        //price
                        var priceString = i.Descendants("div").FirstOrDefault().GetAttributeValue("data-price", "");
                        //Socket
                        var socket = i.Descendants("strong")
                            .Where(node => node.GetAttributeValue("class", "")
                            .Equals("catalog-taxons-product-key-attribute-list__item-value")).FirstOrDefault().InnerText;
                        //converting price string to int
                        double price = 0;
                        double.TryParse(priceString, out price);

                        //adding scraped processor to processor list
                        processors.Add(new Processor() { url = link, name = String.Join(" ", name.Split().Skip(1)), price = price, socket = socket });

                    }
                    cpuPage++;
                }
            }
            return processors;
        }
    }
}
