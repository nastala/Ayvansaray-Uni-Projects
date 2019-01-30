using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var SiniflardakiEnYuksekOrtalamalar =
                            from Ogrenci in Ogrenciler
                            group Ogrenci by Ogrenci.Sinif into SinifGrubu
                            select new
                            {
                                Sinif = SinifGrubu.Key,
                                EnYuksekOrtalama = SinifGrubu.Max(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                            };

            Console.WriteLine("Sınıflardaki en yüksek ortalamalar.");

            foreach (var Satir in SiniflardakiEnYuksekOrtalamalar)
            {
                Console.WriteLine("{0}. sınıftaki en yüksek ortalama = {1}", Satir.Sinif, Satir.EnYuksekOrtalama);
            }
            Console.WriteLine("-----------------------------------------------------");
            //Linq Method Syntax
            var SiniflardakiEnYuksekOrtalamalarMS =
               Ogrenciler.GroupBy(Ogrenci => Ogrenci.Sinif)
                         .Select(SinifGrubu =>
                                 new {
                                     Sinif = SinifGrubu.Key,
                                     EnYuksekOrtalama = SinifGrubu.Max(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                                 }
                                );

            Console.WriteLine("Sınıflardaki en yüksek ortalamalar.");

            foreach (var Satir in SiniflardakiEnYuksekOrtalamalarMS)
            {
                Console.WriteLine("{0}. sınıftaki en yüksek ortalama = {1}", Satir.Sinif, Satir.EnYuksekOrtalama);
            }
            Console.ReadLine();
        }
    }
}
