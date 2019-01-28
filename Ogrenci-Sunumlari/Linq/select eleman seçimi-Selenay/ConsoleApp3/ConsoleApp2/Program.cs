using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Class1;

//  3   -   FirstOrDefault İle İlk Elemanı Veya Yoksa Varsayılan Bir Değer Seçme
//listede hiç eleman yoksa ve listedeki elemanlar tamsayı ise tamsayıların varsayalın değerini (0), bir nesne ise null değerini döndürür.

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sayilar = {1,2,3 };
            Kayit[] Ogrenciler = { };

            int IlkTamsayiVeyaVarsayilanTamsayi = Sayilar.FirstOrDefault();
            Kayit IlkVeyaVarsayilanKayitDegeri = Ogrenciler.FirstOrDefault();

            Console.WriteLine("Dizilerdeki ilk elemanlar veya eleman yoksa varsayılan değerler :");

            Console.WriteLine(IlkTamsayiVeyaVarsayilanTamsayi);
            Console.WriteLine(IlkVeyaVarsayilanKayitDegeri == null ? "null" : IlkVeyaVarsayilanKayitDegeri.Adi);
            Console.ReadLine();


        }
    }
}
