using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Google.Apis.Services;
using Google.Apis.Urlshortener.v1;
using Google.Apis.Urlshortener.v1.Data;

namespace ScraperLibrary
{
    public class UrlShort
    {
        //gets the long url and passes it to the API
        public virtual string getUrl(string LongUrl)
        {
            try
            {
                WebClient wc = new WebClient();
                return wc.DownloadString("http://tinyurl.com/api-create.php?url=" + LongUrl);
            }
            catch (Exception)
            {
                return LongUrl;//if cannot connect, return the long URL
            }
        }
        
        //gets the shortened url and checks if it is fine, if not - returns either a default (1a.lt) or the passed in one
        public string shortenUrl(string url)
        {
            if (url == null)
            {
                return "1a.lt";
            }
            else
            { 
                string text = getUrl(url);
                if (text == "Error" || text == "")//if API can't process URL, return default
                {
                    return "1a.lt";
                }
                else return text;
            }
        }
    }

}
