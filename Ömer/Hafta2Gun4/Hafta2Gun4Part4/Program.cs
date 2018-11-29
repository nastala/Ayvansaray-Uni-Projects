using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100, min = 1, numberOfTries = 0;
            while (true)
            {
                var guess = (max + min) / 2;
                Console.Write($"Is it {guess}? (h/l/c) :");
                var answer = Console.ReadKey().KeyChar;
                numberOfTries++;
                Console.WriteLine();
                switch (answer)
                {
                    case 'h':
                        min = guess;
                        continue;
                    case 'l':
                        max = guess;
                        continue;
                    case 'c':
                        Console.WriteLine($"Number of Tries : {numberOfTries}");
                        Console.ReadKey();
                        return;
                    default:
                        continue;
                }
            }
        }
    }
}
