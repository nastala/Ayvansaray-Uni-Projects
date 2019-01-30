using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

namespace JoinIleKalanlarDahilBirletirme_LeftOuterJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kulupler = KulupleriGetir();

            var Ogrenciler = OgrencileriGetir();

            var KuluplerVeOgrencileri =
                        from Kulup in Kulupler
                        join Ogrenci in Ogrenciler on Kulup.KayitNo equals Ogrenci.Kulup into KulupVeOgrencileri
                        from Ogrenci in KulupVeOgrencileri.DefaultIfEmpty()
                        select new
                        {
                            Ogrenci = Ogrenci == null ? "(Öğrenci yok)" : Ogrenci.Adi,
                            KulupAdi = Kulup.Adi
                        };

            foreach (var Satir in KuluplerVeOgrencileri)
            {
                Console.WriteLine("{0}, {1} kulübüne üye.", Satir.Ogrenci, Satir.KulupAdi);
            }
            Console.ReadLine();
        }
    }
}
