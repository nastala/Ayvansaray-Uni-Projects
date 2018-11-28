using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 3, Part 1 <-----> 28.11.2018

            int iSatir, iSutun;

            while (true)
            {
                Console.Write("Satır sayisini girin: ");
                try
                {
                    iSatir = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bir sayı girmelisiniz!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Girdiğiniz sayı çok büyük!");
                    continue;
                }
            }

            while (true)
            {
                Console.Write("Sutun sayisini girin: ");
                try
                {
                    iSutun = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bir sayı girmelisiniz!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Girdiğiniz sayı çok büyük!");
                    continue;
                }
            }

            for (int i = 0; i < iSatir; i++)
            {
                for(int j = 0; j < iSutun; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
