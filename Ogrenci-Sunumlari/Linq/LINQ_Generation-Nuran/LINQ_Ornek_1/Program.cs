using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Ornek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randomSayi = Enumerable.Repeat(0, 8).Select(i => rand.Next(10,100));
            foreach (int Sayi in randomSayi)
            {
                Console.WriteLine(Sayi);
            }
            Console.ReadLine();



        }
    }
}
