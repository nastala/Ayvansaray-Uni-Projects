using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4
{
    class Program
    {
        //Hafta 2, Gün 4, Part 1 <-----> 29.11.2018

        static Random r;

        static void Main(string[] args)
        {
            int[] sansliNumaralar = new int[6];
            r = new Random();

            for (int i = 0; i < sansliNumaralar.Length; i++)
                sansliNumaralar[i] = sayiUret();

            sayilariYazdir(sansliNumaralar);

            Console.ReadKey();
        }

        static void sayilariYazdir(int[] sayilar)
        {
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }

        static int sayiUret()
        {
            return r.Next(1, 49);
        }
    }
}
