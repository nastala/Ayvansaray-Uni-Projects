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

        static void Main(string[] args)
        {
            int[] sansliNumaralar = new int[6];
            Random r = new Random();
            int uretilenSayi;

            for (int i = 0; i < sansliNumaralar.Length; i++)
            {
                uretilenSayi = r.Next(1, 49);
                if (!(Array.IndexOf(sansliNumaralar, uretilenSayi) >= 0))
                    sansliNumaralar[i] = uretilenSayi;
                else
                {
                    i--;
                    continue;
                }
                
            }
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
    }
}
