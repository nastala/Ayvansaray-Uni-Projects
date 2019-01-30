using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enumerable.Repeat  yöntemi, LINQ ile kullanılabilecek bir tekrarlanmış tamsayılardan oluşan bir liste sağlar.

            var Sayilar = Enumerable.Repeat(11, 5);

            Console.WriteLine("Aşağıda kaç tane 11 var?");

            foreach (var BirSayi in Sayilar)
            {
                Console.WriteLine(BirSayi);
            }
            Console.ReadLine();



        }
        }
    }
