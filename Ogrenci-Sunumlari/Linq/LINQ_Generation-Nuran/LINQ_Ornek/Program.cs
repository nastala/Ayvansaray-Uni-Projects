using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] minusArray = Enumerable.Repeat(-1, 10).ToArray();
                int[] positiveArray = Enumerable.Range(0, 10).ToArray();
                int[] hunderedArray = Enumerable.Range(0, 10).Select(i => 100 + 10 * i).ToArray();
                foreach (int item in minusArray)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-".PadLeft(20, '-'));
                foreach (int item in positiveArray)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-".PadLeft(20, '-'));
                foreach (int item in hunderedArray)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }

