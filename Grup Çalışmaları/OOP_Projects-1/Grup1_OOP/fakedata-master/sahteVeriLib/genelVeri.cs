using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sahteVeriLib
{
    //public struct Hayvanlar
    // {
    //     public string hayvanAdi { get; set; }
    //     public string[] ayakSayısı { get; set; }
    //     public string[] ses { get; set; }
    // }
    public class HayvanOzel
    {
        public string Renk { get; set; }
        public string OzelAd { get; set; }
        public string Yas { get; set; }

    }
    public class Hayvanlar : HayvanOzel
    {
        public string hayvanAdi { get; set; }
        public string ayakSayısı { get; set; }
        public string ses { get; set; }
    }
    public class genelVeri
    {
        private static ozelVeri _ozelveri = new ozelVeri();

        public Hayvanlar[] hayvanDizi =
        {
            new Hayvanlar {hayvanAdi = "kedi", ayakSayısı ="4", ses="miyav" },
            new Hayvanlar {hayvanAdi = "yılan", ayakSayısı ="0",ses="tıss" },
            new Hayvanlar {hayvanAdi = "kurbağa", ayakSayısı ="4",ses = "vrag" },
            new Hayvanlar {hayvanAdi = "kuş", ayakSayısı ="2",ses="cik cik"},
            new Hayvanlar {hayvanAdi = "kırkayak", ayakSayısı ="40",ses="alo"}
        };
    }
}
