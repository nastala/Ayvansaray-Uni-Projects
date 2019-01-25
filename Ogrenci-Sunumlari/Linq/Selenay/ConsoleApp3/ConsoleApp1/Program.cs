using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

// 2  -  First İle Şarta Uyan İlk Elemanı Seçme
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = OgrencileriGetir();

            var ListedekiIlkBayanOgrenci = Ogrenciler.First(Ogrenci => Ogrenci.Cinsiyet == "Bayan");

            Console.WriteLine("Listedeki ilk bayan öğrenci :");

            Console.WriteLine("{0} {1}", ListedekiIlkBayanOgrenci.Adi, ListedekiIlkBayanOgrenci.Soyadi);
            Console.ReadLine();



        }
    }
}
