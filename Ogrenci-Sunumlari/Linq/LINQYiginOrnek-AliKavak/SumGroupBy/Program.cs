using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var OkunanKitapSayilariToplamlari =
                from Ogrenci in Ogrenciler
                group Ogrenci by Ogrenci.Sinif into SinifGrubu
                select new
                {
                    Sinifi = SinifGrubu.Key,
                    KitapOkumaSayilariToplami = SinifGrubu.Sum(GruptakiOgrenci => GruptakiOgrenci.OkunanKitapSayisi)
                };

            Console.WriteLine("Sınıflara göre okunan kitap sayıları toplamları...");

            foreach (var Satir in OkunanKitapSayilariToplamlari)
            {
                Console.WriteLine("{0}. sınıftaki öğrenciler toplam {1} kitap okumuşlar.",
                                  Satir.Sinifi,
                                  Satir.KitapOkumaSayilariToplami);
            }

            Console.WriteLine("-------------------------------------------------------------");
            // Linq METHOD SYNTAX
            var OkunanKitapSayilariToplamlariMS =
        Ogrenciler.GroupBy(Ogrenci => Ogrenci.Sinif)
                  .Select(SinifGrubu => new {
                      Sinifi = SinifGrubu.Key,
                      KitapOkumaSayilariToplami = SinifGrubu.Sum(GruptakiOgrenci => GruptakiOgrenci.OkunanKitapSayisi)
                  });

            Console.WriteLine("Sınıflara göre okunan kitap sayıları toplamları...");

            foreach (var Satir in OkunanKitapSayilariToplamlariMS)
            {
                Console.WriteLine("{0}. sınıftaki öğrenciler toplam {1} kitap okumuşlar.",
                                  Satir.Sinifi,
                                  Satir.KitapOkumaSayilariToplami);
            }
            Console.ReadLine();
        }
    }
}
