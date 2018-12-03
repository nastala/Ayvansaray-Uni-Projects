using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun5
{
    class Program
    {
        //Hafta 2, Gün 5, Part 1 <-----> 30.11.2018

        static void Main(string[] args)
        {
            Console.Write("Input :");
            var amount = int.Parse(Console.ReadLine());
            var limit = Math.Pow(2, amount);
            var count = 0;

            void Combination(IList<bool> arr, int lastIndex)
            {
                foreach (var val in arr)
                {
                    Console.Write(val + " ");
                }

                Console.WriteLine();
                arr[lastIndex] = !arr[lastIndex++];
                if (lastIndex >= arr.Count) lastIndex = 0;
                if (++count >= limit)
                {
                    return;
                }
                Combination(arr, lastIndex);
            }
            Combination(new bool[amount], 0);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
