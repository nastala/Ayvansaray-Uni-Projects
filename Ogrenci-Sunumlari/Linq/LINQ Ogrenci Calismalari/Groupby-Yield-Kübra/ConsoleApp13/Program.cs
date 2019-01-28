using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp13
{
    public class Program
    {
        static void Main(string[] args)
        {
            var  Ogrenciler = Class1.OgrencileriGetir();

            var Siniflar = from Ogrenci in Ogrenciler
                           orderby Ogrenci.Sinif
                           group Ogrenci by Ogrenci.Sinif into Sinifi
                           select new { Sinif = Sinifi.Key, OgrenciSayisi = Sinifi.Count() };

            //LinQ Yöntem Sözdizimi ile Sorgu;
            //var Siniflar =
            //   Ogrenciler.OrderBy(Ogrenci => Ogrenci.Sinif)
            //             .GroupBy(Ogrenci => Ogrenci.Sinif)
            //             .Select(Sinif => new { Sinif = Sinif.Key, OgrenciSayisi = Sinif.Count() });

            Console.WriteLine("Sınıf öğrenci sayıları :");

            foreach (var Satir in Siniflar)
            {
                Console.WriteLine("{0}. sınıfta {1} öğrenci var.", Satir.Sinif, Satir.OgrenciSayisi);
            }
            Console.ReadLine();
        }
    }
}
