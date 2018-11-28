using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun3Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 3, Part 4 <-----> 28.11.2018

            string inceUnluler = "eiöü";
            string kalinUnluler = "aıou";
            bool kontrolInce = false;
            bool kontrolKalin = false;
            string kelime;

            Console.Write("Bir kelime giriniz: ");
            kelime = Console.ReadLine();

            for(int i = 0; i < kelime.Length; i++)
            {
                if (kalinUnluler.IndexOf(kelime[i]) >= 0)
                    kontrolKalin = true;
                else if (inceUnluler.IndexOf(kelime[i]) >= 0)
                    kontrolInce = true;
            }

            if (kontrolKalin && kontrolInce)
                Console.WriteLine("Büyük Ünlü Uyumuna uyumlu değil.");
            else
                Console.WriteLine("Büyük Ünlü Uyumuna uyumlu.");

            Console.ReadKey();
        }
    }
}
