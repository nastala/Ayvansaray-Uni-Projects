using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hafta3Gun4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 3, Gün 4, Part 2 <-----> 06.12.2018

            Hashtable Sozluk = new Hashtable();
            Sozluk.Add("araba", "car");
            Sozluk.Add("kitap", "book");

            ICollection anahtarlar = Sozluk.Keys;
            foreach (string anahtar in anahtarlar)
                Console.WriteLine(anahtar);

            Console.WriteLine("------------------------------------");

            ICollection degerler = Sozluk.Values;
            foreach (string deger in degerler)
                Console.WriteLine(deger);

            Console.ReadKey();
        }
    }
}
