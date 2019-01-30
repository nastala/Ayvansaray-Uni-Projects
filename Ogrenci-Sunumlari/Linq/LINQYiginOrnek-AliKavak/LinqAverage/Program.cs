using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 51, 14, 21, 23, 93, 83, 26, 37, 42, 50 };

            double ortalama = sayilar.Average();

            Console.WriteLine("Dizideki sayıların ortalaması {0}.", ortalama);

            Console.WriteLine("-------------------------------------------------------");

            string[] Kelimeler = { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya", "Bursa" };

            double OrtalamaUzunluk = Kelimeler.Average(Kelime => Kelime.Length);

            Console.WriteLine("Dizideki kelimelerin ortalama uzunluğu = {0}", OrtalamaUzunluk);

            Console.ReadLine();
        }
    }
}
