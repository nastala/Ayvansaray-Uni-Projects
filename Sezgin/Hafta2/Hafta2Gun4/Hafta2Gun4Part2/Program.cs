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

            int fibSayisi;
            uint[] fibSayilar;

            fibSayilar = new uint[100];
            fibSayilar = nTaneUret(100);
            sayilariYazdir(fibSayilar);

            Console.WriteLine("------------------------------------");

            fibSayisi = fibSayisiIste("Kaç tane fibonacci sayısı üretmek istersiniz? ");
            fibSayilar = new uint[fibSayisi];
            fibSayilar = nTaneUret(fibSayisi);
            sayilariYazdir(fibSayilar);
            //uint deneme = recursiveFib(100);
            //Console.WriteLine("\n" + deneme);

            Console.ReadKey();
        }

        static int fibSayisiIste(string aciklama)
        {
            Console.Write(aciklama);

            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return fibSayisiIste(aciklama = "Sayı girmelisiniz! ");
            }
            catch (OverflowException)
            {
                return fibSayisiIste(aciklama = "Girdiğiniz sayı çok büyük! ");
            }
        }

        static uint[] nTaneUret(int n)
        {
            uint[] fibSayilar = new uint[n];
            uint siradakiSayi;
            fibSayilar[0] = 0;
            fibSayilar[1] = 1;

            for (int i = 2; i < n; i++)
            {
                siradakiSayi = fibSayilar[i - 1] + fibSayilar[i - 2];
                fibSayilar[i] = siradakiSayi;
            }

            return fibSayilar;
        }

        static void sayilariYazdir(uint[] sayilar)
        {
            for(int i = 0; i < sayilar.Length; i++)
                Console.Write(sayilar[i] + " ");
        }

        //static uint recursiveFib(int index)
        //{
        //    if (index <= 0)
        //        return 0;
        //    else if (index == 1 || index == 2)
        //        return 1;
        //    else
        //        return recursiveFib(index - 1) + recursiveFib(index - 2);
        //}
    }
}
