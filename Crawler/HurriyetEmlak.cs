using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    public class HurriyetEmlak : CrawlerUtils
    {
        public List<string> CrawlURLs { get; set; }
        public HurriyetEmlak(string link) : base(link)
        {
        }

        public void GetCrawlURLs()
        {
            CrawlURLs = new List<string>();

            var rawDataList = CrawlNodes("//*[contains(@class,'read-count-container')]");

            foreach (var item in rawDataList)
            {
                CrawlURLs.Add("https://www.cnnturk.com" + item.Attributes["href"].Value);
            }
        }

        public string Data(string link)
        {
            CrawlerUtils cu = new CrawlerUtils(link);
            var rawDataList = cu.CrawlNodes("//*[contains(@class,'detail-title')]");
            return rawDataList.FirstOrDefault().InnerHtml;
        }
    }
}
