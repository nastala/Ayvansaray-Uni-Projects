using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace CaprazBirlestirme_CrossJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Kulupler = KulupleriGetir();

            //var Ogrenciler = OgrencileriGetir();

            //var OgrencilerVeKulupSorumlulari =
            //    from Ogrenci in Ogrenciler
            //    join Kulup in Kulupler on Ogrenci.Kulup equals Kulup.KayitNo
            //    select new { OgrenciAdi = Ogrenci.Adi, KulupAdi = Kulup.Adi, KulupSorumlusu = Kulup.Sorumlu };

            //Console.WriteLine("Öğrenciler ve üye oldukları kulüplerin rehber öğretmenleri :");

            //foreach (var Nesne in OgrencilerVeKulupSorumlulari)
            //{
            //    Console.WriteLine("{0} isimli öğrenci {1} kulübüne üyedir. Kulübün rehber öğretmeni: {2}.",
            //                      Nesne.OgrenciAdi,
            //                      Nesne.KulupAdi,
            //                      Nesne.KulupSorumlusu);
            //}
            //Console.ReadLine();


            // LINQ Yöntem ile;

            var Ogrenciler = OgrencileriGetir();

            var Kulupler = KulupleriGetir();

            var OgrencilerVeKulupSorumlulari = Ogrenciler.SelectMany
                                                      (Ogrenci => Kulupler.Where
                                                      (Kulup => Kulup.KayitNo ==Ogrenci.Kulup),
                                                      (Ogrenci, Kulup) => new
                                                      {
                                                          OgrenciAdi = Ogrenci.Adi,
                                                          KulupAdi = Kulup.Adi,
                                                          KulupSorumlusu = Kulup.Sorumlu
                                                      });

            Console.WriteLine("Öğrenciler ve üye oldukları kulüplerin rehber öğretmenleri :");

            foreach (var Nesne in OgrencilerVeKulupSorumlulari)
            {
                Console.WriteLine("{0} isimli öğrenci {1} kulübüne üyedir. Kulübün rehber öğretmeni: {2}.",
                                  Nesne.OgrenciAdi,
                                  Nesne.KulupAdi,
                                  Nesne.KulupSorumlusu);
            }
            Console.ReadLine();


        }
    }
}
