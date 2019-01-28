using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Enumerable.Range"  Metodu, LINQ ile kullanılabilecek bir tamsayı aralığı sağlar
            var Sayilar = from TamSayi in Enumerable.Range(100, 11)
                          select new { Sayi = TamSayi, TekMi = TamSayi % 2 == 1 };

            Console.WriteLine("100 ile 110 arasındaki sayıların tek / çift olma durumları :");

            foreach (var BirSayi in Sayilar)
            {
                Console.WriteLine("Sayı {0} {1}tir.", BirSayi.Sayi, BirSayi.TekMi ? "tek" : "çift");


                //if (BirSayi.TekMi)
                //{
                //    Console.WriteLine("Sayı {0} Tektir", BirSayi.Sayi);
                //}
                //else
                //{
                //    Console.WriteLine("Sayı {0} Çifttir", BirSayi.Sayi);
                //}
            }
            Console.ReadLine();
        }
    }
}
