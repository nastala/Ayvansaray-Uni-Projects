using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var SiniflarinNotOrtalamalari =
                       from Ogrenci in Ogrenciler
                       group Ogrenci by Ogrenci.Sinif into SinifGrubu
                       select new
                       {
                           Sinifi = SinifGrubu.Key,
                           OrtalamaNot = SinifGrubu.Average(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                       };

            Console.WriteLine("Sınıfların not ortalamaları :");

            foreach (var Satir in SiniflarinNotOrtalamalari)
            {
                Console.WriteLine("{0}. sınıfın not ortalaması = {1}", Satir.Sinifi, Satir.OrtalamaNot);
            }

            Console.WriteLine("-------------------------------------------------------");
            //Linq Method Syntax

            var SiniflarinNotOrtalamalariMS =

           Ogrenciler.GroupBy(Ogrenci => Ogrenci.Sinif)
           .Select(SinifGrubu => new
           {
               Sinif = SinifGrubu.Key,
               OrtalamaNot = SinifGrubu.Average(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
           });

            Console.WriteLine("Sınıfların not ortalamaları :");

            foreach (var Satir in SiniflarinNotOrtalamalariMS)
            {
                Console.WriteLine("{0}. sınıfın not ortalaması = {1}", Satir.Sinif, Satir.OrtalamaNot);
            }
            Console.ReadLine();
        }
    }
}
