using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;
//   4    -  FirstOrDefault İle Şarta Uyan İlk Elemanı Veya Yoksa Varsayılan Bir Değer Seçme
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            var Ogrenciler = OgrencileriGetir();

            var SecilenOgrenci = Ogrenciler.FirstOrDefault(Ogrenci => Ogrenci.DogumTarihi.Year == 2003);

            Console.WriteLine("2003 yılında doğan öğrenci {0}.", SecilenOgrenci == null ? "yok" : "var");
            Console.ReadLine();

        }
    }
}
