using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ScraperLibrary
{
    public class Motherboard : IHtmlGetter
    {
        public string? url;
        public string? name;
        public double price;
        public string? chipset;
        public string? socket;
        public string? ffactor;

        public override string ToString()
        {
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
        //Scraping Motherboard Listings
        public List<Motherboard> GetHtmlAsync()
        {
            List<Motherboard> motherboards = new List<Motherboard>();

            var moboUrl1 = "https://www.1a.lt/c/kompiuteriu-komponentai-tinklo-produktai/komponentai/pagrindines-plokstes/2ve?page=";
            var moboPage = 1;
            var moboUrl2 = "&page_per=72";
            var MoboHtmlDocument = new HtmlDocument();
            Motherboard m = new Motherboard();

            while (true)
            {
                //creating url for every page
                var moboUrl = moboUrl1 + moboPage.ToString() + moboUrl2;

                var moboHtml = m.getHtml(moboUrl);

                if (moboHtml == "Error")//exit writing to list if cannot connect or everything has been scraped
                {
                    break;
                }
                else
                {
                    MoboHtmlDocument.LoadHtml(moboHtml);

                    var MbList = MoboHtmlDocument.DocumentNode.Descendants("div")
                        .Where(node => node.GetAttributeValue("class", "")
                        .Equals("catalog-taxons-product catalog-taxons-product--grid-view")).ToList();

                    foreach (var i in MbList)
                    {
                        //link
                        var link = "https://www.1a.lt" + i.Descendants("a").FirstOrDefault().GetAttributeValue("href", "");
                        //name
                        var name = i.Descendants("div").FirstOrDefault().GetAttributeValue("data-name", "");
                        //price
                        var priceString = i.Descendants("div").FirstOrDefault().GetAttributeValue("data-price", "");
                        //Chipset
                        var chipset = i.Descendants("strong")
                            .Where(node => node.GetAttributeValue("class", "")
                            .Equals("catalog-taxons-product-key-attribute-list__item-value")).FirstOrDefault().InnerText;
                        //Socket
                        var socket = i.Descendants("strong")
                            .Where(node => node.GetAttributeValue("class", "")
                            .Equals("catalog-taxons-product-key-attribute-list__item-value")).Skip(2).FirstOrDefault().InnerText;
                        //Form Factor
                        var ffactor = i.Descendants("strong")
                            .Where(node => node.GetAttributeValue("class", "")
                            .Equals("catalog-taxons-product-key-attribute-list__item-value")).Skip(1).FirstOrDefault().InnerText;
                        //converting price string to int
                        double price = 0;
                        double.TryParse(priceString, out price);
                        //adding scraped processor to processor list
                        motherboards.Add(new Motherboard() { url = link, name = String.Join(" ", name.Split().Skip(2)), price = price, chipset = chipset, socket = socket, ffactor = ffactor });
                    }
                    //going to the next page
                    moboPage++;
                }
            }
            return motherboards;
        }
    }
}
