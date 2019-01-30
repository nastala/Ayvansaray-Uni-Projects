using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yuvalanmış(Nested) GroupBy Örneği

            var Ogrenciler = Class1.OgrencileriGetir();

            var CinsiyeteGoreSinifListeleri =
                    from Ogrenci in Ogrenciler
                    orderby Ogrenci.No
                    group Ogrenci by Ogrenci.Sinif into SinifGrubu
                    select new
                    {
                        SinifNo = SinifGrubu.Key,
                        SinifOgrencileri = from BuSiniftakiOgrenci in SinifGrubu
                                           orderby BuSiniftakiOgrenci.Cinsiyet
                                           group BuSiniftakiOgrenci by BuSiniftakiOgrenci.Cinsiyet into SinifCinsiyetGrubu
                                           select SinifCinsiyetGrubu
                    };

            //LinQ Yöntem Sözdizimi ile Sorgu;
            //var CinsiyeteGoreSinifListeleri = 
            //        Ogrenciler.OrderBy(Ogrenci => Ogrenci.No)
            //            .GroupBy(Ogrenci => Ogrenci.Sinif)
            //            .Select(SinifGrubu =>
            //            new
            //            {
            //                SinifNo = SinifGrubu.Key,
            //                SinifOgrencileri =
            //                      SinifGrubu.OrderBy(BuSiniftakiOgrenci => BuSiniftakiOgrenci.Cinsiyet)
            //                                .GroupBy(BuSiniftakiOgrenci => BuSiniftakiOgrenci.Cinsiyet)
            //            });

            Console.WriteLine("Cinsiyete Göre Gruplanmış Sınıf Öğrenci Listeleri...");

            foreach (var Sinif in CinsiyeteGoreSinifListeleri)
            {

                Console.WriteLine("\n{0}. sınıf öğrencileri :", Sinif.SinifNo);

                foreach (var OgrenciGrubu in Sinif.SinifOgrencileri)
                {
                    Console.WriteLine("{0} öğrenciler:", OgrenciGrubu.Key);
                    foreach (var Ogrenci in OgrenciGrubu)
                    {
                        Console.WriteLine("{0} - {1} {2}",
                                          Ogrenci.No,
                                          Ogrenci.Adi,
                                          Ogrenci.Soyadi);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
