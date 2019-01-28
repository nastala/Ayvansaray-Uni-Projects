using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var Siniflar = from Ogrenci in Ogrenciler
                           orderby Ogrenci.Sinif
                           group Ogrenci by Ogrenci.Sinif into SinifGrubu
                           select SinifGrubu;

            //LinQ Yöntem Sözdizimi ile Sorgu;
            //var Siniflar = Ogrenciler.OrderBy(Ogrenci => Ogrenci.Sinif).GroupBy(Ogrenci => Ogrenci.Sinif);

            Console.WriteLine("Sınıflardaki öğrenciler...");

            foreach (var BirSiniftakiler in Siniflar)
            {

                Console.WriteLine("{0}. sınıftaki öğrenciler :", BirSiniftakiler.Key);

                foreach (var Ogrenci in BirSiniftakiler)
                {
                    Console.WriteLine("{0} {1}", Ogrenci.Adi, Ogrenci.Soyadi);
                }
            }
            Console.ReadLine();
        }
    }
}
