using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun5Part2
{
    class Program
    {
        //Hafta 2, Gün 5, Part 2 <-----> 30.11.2018

        static void Main(string[] args)
        {
            Console.Write("Input :");
            var amount = int.Parse(Console.ReadLine());
            var vals = new bool[amount];
            var limit = Math.Pow(2, amount);
            var changeIndex = 0;
            var count = 0;

            for (int q = 0; q < limit; q++)
            {
                foreach (var val in vals)
                {
                    Console.Write(val + " ");
                }

                Console.WriteLine();
                vals[changeIndex] = !vals[changeIndex++];
                if (changeIndex >= amount) changeIndex = 0;
                ++count;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
