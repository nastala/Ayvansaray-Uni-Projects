using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

// 1  -  First İle İlk Elemanı Seçme

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Ogrenciler = OgrencileriGetir();

            //Kayit ListedekiIlkBayanOgrenci = (
            //                                  from Ogrenci in Ogrenciler
            //                                  where Ogrenci.Cinsiyet == "b"
            //                                  select Ogrenci
            //                                 ).First();

            //Console.WriteLine("Listedeki ilk bayan öğrenci :");

            //Console.WriteLine("{0} {1}", ListedekiIlkBayanOgrenci.Adi, ListedekiIlkBayanOgrenci.Soyadi);
            //Console.ReadLine();


            var Ogrenciler = OgrencileriGetir();

            Kayit ListedekiIlkBayanOgrenci = Ogrenciler.Where(Ogrenci => Ogrenci.Cinsiyet == "Bayan").First();

            Console.WriteLine("Listedeki ilk bayan öğrenci :");

            Console.WriteLine("{0} {1}", ListedekiIlkBayanOgrenci.Adi, ListedekiIlkBayanOgrenci.Soyadi);
            Console.ReadLine();
        }
    }
}
