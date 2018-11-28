using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun3
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels1 = "auıo";
            var vowels2 = "eiöü";
            Console.Write("Word :");
            var word = Console.ReadLine();
            var first = false;
            var second = false;
            if (word != null)
                foreach (var letter in word)
                {
                    if (vowels1.Contains(letter) == true)
                    {
                        if (second == true)
                        {
                            first = true;
                            break;
                        }
                        first = true;
                    }
                    else if (vowels2.Contains(letter) == true)
                    {
                        if (first == true)
                        {
                            second = true;
                            break;
                        }
                        second = true;
                    }
                }

            switch (first)
            {
                case true when second == true:
                    Console.WriteLine("No Match");
                    break;
                case true:
                    Console.WriteLine("First Rule");
                    break;
                default:
                    {
                        Console.WriteLine(second == true ? "Second Rule" : "Error");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
