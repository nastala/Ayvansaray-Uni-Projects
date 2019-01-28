using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;


namespace JoinIleGruplarOlusturma
{
    class Program
    {
        //LINQ Örnekleri makalelerinde kullanılan verikaynağı
        //--http://yazilim.cevapsitesi.com/EtiketMakalesi/linq_11/4/linq-ornekleri-makalelerinde-kullanilan-verikaynagi

        static void Main(string[] args)
        {
            var Kulupler = KulupleriGetir();

            var Ogrenciler = OgrencileriGetir();

            var KuluplerVeOgrencileri =
                        from Kulup in Kulupler
                        join Ogrenci in Ogrenciler on Kulup.KayitNo equals Ogrenci.Kulup into KulupVeOgrencileri
                        select new
                        {
                            KulupVeOgrencileri = KulupVeOgrencileri,
                            OgrenciSayisi = KulupVeOgrencileri.Count(),
                            KulupAdi = Kulup.Adi
                            
                        };

            foreach (var Satir in KuluplerVeOgrencileri)
            {

                Console.WriteLine("{0} kulübüne üye {1} öğrenci var. Öğrenciler :",
                                  Satir.KulupAdi,
                                  Satir.OgrenciSayisi
                                  //Satir.KulupVeOgrencileri.Adi
                                  );


                foreach (var a in Satir.KulupVeOgrencileri)
                {
                    Console.WriteLine(a.Adi);

                }

            }
            Console.ReadLine();

            //LINQ Yöntem ile;

            //var Kulupler = KulupleriGetir();

            //var Ogrenciler = OgrencileriGetir();

            //var KuluplerVeOgrencileri =
            //            Kulupler.GroupJoin(Ogrenciler,
            //                               Kulup => Kulup.KayitNo,
            //                               Ogrenci => Ogrenci.Kulup,
            //                               (Kulup, KulupVeOgrencileri) => new
            //                               {
            //                                   KulupVeOgrencileri = KulupVeOgrencileri,
            //                                   OgrenciSayisi = KulupVeOgrencileri.Count(),
            //                                   KulupAdi = Kulup.Adi
            //                               });

            //foreach (var Satir in KuluplerVeOgrencileri)
            //{

            //    Console.WriteLine("{0} kulübüne üye {1} öğrenci var. Öğrenciler :",
            //                      Satir.KulupAdi,
            //                      Satir.OgrenciSayisi);

            //    foreach (var a in Satir.KulupVeOgrencileri)
            //    {
            //        Console.WriteLine(a.Adi);
            //    }

            //}
            //Console.ReadLine();
        }
    }
}
