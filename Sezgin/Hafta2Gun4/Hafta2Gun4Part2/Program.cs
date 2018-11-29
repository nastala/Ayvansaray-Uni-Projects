using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 4, Part 2 <-----> 29.11.2018

            uint siradakiSayi;
            uint[] fibSayilar = new uint[100];
            fibSayilar[0] = 0;
            fibSayilar[1] = 1;

            for(int i = 2; i < 100; i++)
            {
                siradakiSayi = fibSayilar[i - 1] + fibSayilar[i - 2];
                fibSayilar[i] = siradakiSayi;
            }

            for(int i = 0; i < fibSayilar.Length; i++)
            {
                Console.Write(fibSayilar[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
