using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun3Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 3, Part 2 <-----> 28.11.2018

            int iSayi;
            Random r = new Random();

            do
            {
                iSayi = r.Next(1, 101);
                Console.WriteLine(iSayi);
            } while (iSayi != 50);

            Console.ReadKey();
        }
    }
}
