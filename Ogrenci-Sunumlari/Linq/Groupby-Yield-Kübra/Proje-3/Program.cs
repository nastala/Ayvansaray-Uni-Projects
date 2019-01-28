using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var Siniflar = from Ogrenci in Ogrenciler
                           orderby Ogrenci.Sinif
                           group Ogrenci by Ogrenci.Ortalama >= 55 into BasariGrubu
                           select BasariGrubu;

            //LinQ Yöntem Sözdizimi ile Sorgu;
            //var Siniflar = Ogrenciler.GroupBy(Ogrenci => Ogrenci.Ortalama >= 55);

            Console.WriteLine("Öğrencilerin Başarı Durumları...");

            foreach (var BasariGrubu in Siniflar)
            {

                Console.WriteLine("\n- {0} öğrenciler :", BasariGrubu.Key ? "Başarılı" : "Başarısız");

                foreach (var Ogrenci in BasariGrubu)
                {
                    Console.WriteLine("{0} {1} -> {2:0.00}", Ogrenci.Adi, Ogrenci.Soyadi, Ogrenci.Ortalama);
                }

            }
            Console.ReadLine();
        }
    }
}
