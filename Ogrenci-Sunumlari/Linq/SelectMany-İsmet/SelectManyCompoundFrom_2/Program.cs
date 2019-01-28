using LinqVeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyCompoundFrom_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();
            List<KulupKaydi> Kulupler = Class1.KulupleriGetir();
            var UyeOlunanKulupler =
                                    Ogrenciler.SelectMany(Ogrenci =>Kulupler
                                    .Where(Kulup => Kulup.KayitNo == Ogrenci.Kulup),
                                    (Ogrenci, Kulup) => new { Ogrenci.Adi, KulupAdi = Kulup.Adi });
            Console.WriteLine("Öğrenciler ve kulupleri :");
            foreach (var Satir in UyeOlunanKulupler)
            {
                Console.WriteLine("{0}, {1} kulübüne üye.", Satir.Adi, Satir.KulupAdi);
            }
            Console.ReadLine();
        }
    }
}
