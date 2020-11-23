using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
    public class RegularExpressionsUtils //RegEx
    {
        /*Regex İfadeleri:
             * ^: Başlangıç: Metni başından itibaren taramk için kullanılır. Olmazsa ortalarından da başlayabilir. (StartWith)
             * $: Son: Metnin nereye kadar taranacağını belirler. (EndsWith)
             * [ ]: Küme parantezi, içinde belirtilen değerleri arar.
             *      a-z : a ile z arasındaki tüm karakterler
             *      0-5 : 0 ile 5 arasındaki rakamlar
             *      abc: a,b veya c karakterlerinden biri
             *      [a-zA-Z0-9]: ingilizce olarak tüm yazıları dahil edersiniz.
             * {}: Tekrar sayısı belirleme parantezi: Kaç kez kullanılacağını belirler. 
             *      2,4: 2,3 veya 4 kere yazılabilir.
             *      2,: 2 veya daha fazla yazılabilir.
             *      4: en fazla 4 kere yazılabilir.
             * + : En az bir kere tekrarlı kullanım içindir.
             * * : Olmayabilir veya birden fazla tekrarlı olabilir.
             * ? : Opsiyonel kullanım.
             * . : boşluk olmayan tüm karakterler.
             * | : veya iki durum arasından herhangi biri olabilir.
             * 
             * regexr.com yararlı bir test sitesidir.
             */
        public bool CheckMailFormat(string text)
        {
            Regex r = new Regex(@"^[a-z0-9]{3,}@[a-z0-9]{3,}\.[a-z0-9]{2,3}$");
            return r.IsMatch(text);
        }

        public bool CheckPhoneNumberFormat(string text)
        {
            Regex r = new Regex(@"^(([+]90)|([0]))?5([0345][0-9]|[6][1])[0-9]{7}$");
            return r.IsMatch(text);
        }

        public bool CheckURLFormat(string text)
        {
            Regex r = new Regex(@"^(https:\/\/|http:\/\/)?([a-z]*\.)?([a-z]*\.[a-z]*)(\.[a-z]*)?$");
            return r.IsMatch(text);
        }
    }
}
