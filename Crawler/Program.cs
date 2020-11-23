using System.Collections.Generic;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            //HurriyetEmlak he = new HurriyetEmlak("https://www.cnnturk.com/son-dakika-haberleri");
            //he.GetCrawlURLs();
            //foreach (var item in he.CrawlURLs)
            //{
            //    System.Console.WriteLine(he.Data(item));
            //}
            /*
            RegularExpressionsUtils regular = new RegularExpressionsUtils();
            System.Console.WriteLine(regular.CheckMailFormat("ilkerturan@outlook.com"));
            System.Console.WriteLine(regular.CheckPhoneNumberFormat("0216654832"));
            System.Console.WriteLine(regular.CheckURLFormat("www.doblo.sat"));*/
            List<string> data = new List<string>();
            List<UserContent> list = new List<UserContent>();
            for (int i = 0; i < 10; i++)
            {
                SahibindenCrawler sc = new SahibindenCrawler("https://www.sahibinden.com/emlak?pagingOffset=" + (i * 20));
                sc.GetCrawlURLs();
                data.AddRange(sc.CrawlURLs);
                list.AddRange(sc.GetUserContent());
            }

            foreach (var item in list)
            {
                System.Console.WriteLine(item.ToString());
            }
        }


    }
}
