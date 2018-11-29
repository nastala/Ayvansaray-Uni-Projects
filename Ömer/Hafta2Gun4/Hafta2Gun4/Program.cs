using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 4, Part 1 <-----> 29.11.2018

            var numbers = new HashSet<int>();
            var sorted = new List<int>();
            var random = new Random();
            for (int i = 0; i < 6;)
            {
                int newNumber = random.Next(1, 50);
                if (!numbers.Contains(newNumber))
                {
                    numbers.Add(newNumber);
                    SortedAdd(sorted, newNumber);
                    i++;
                }
            }
            WriteList<int>(sorted);

            Console.ReadKey();
        }

        static void SortedAdd(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (value < list[i])
                {
                    list.Insert(i, value);
                    return;
                }
            }
            list.Add(value);
        }
        static void WriteList<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
