using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;
//   5    -    ElementAt İle Belirtilen Konumdaki Elemanı Seçme 
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = OgrencileriGetir();

            var ListedekiIkinciBayanOgrenci = (
                                               from Ogrenci in Ogrenciler
                                               where Ogrenci.Cinsiyet == "Bayan"
                                               select Ogrenci
                                              ).ElementAt(1);

            Console.WriteLine("Listedeki 2. bayan öğrenci :");

            Console.WriteLine("{0} {1}", ListedekiIkinciBayanOgrenci.Adi, ListedekiIkinciBayanOgrenci.Soyadi);

            //Aynı örnek, LINQ Yöntem Sözdizimi (LINQ Method Syntax) ile şu şekilde yazılabilir:

            //var Ogrenciler = OgrencileriGetir();

            //var ListedekiIkinciBayanOgrenci = Ogrenciler.Where(Ogrenci => Ogrenci.Cinsiyet == "Bayan").ElementAt(1);

            //Console.WriteLine("Listedeki 2. bayan öğrenci :");

            //Console.WriteLine("{0} {1}", ListedekiIkinciBayanOgrenci.Adi, ListedekiIkinciBayanOgrenci.Soyadi);


        }
    }
}
