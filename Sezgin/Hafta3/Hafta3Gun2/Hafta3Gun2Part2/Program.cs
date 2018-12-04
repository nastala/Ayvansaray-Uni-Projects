using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Gun2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> list = new List<long>();
            for (long i = 0; i < 100; i++)
            {
                list.Insert(0, i); //Insert before first element. Slow!
            }

            WriteList(list);

            list.Clear();

            for(long i = 0; i < 100; i++)
            {
                list.Add(i); //Add next to the last item. Fast!
            }

            list.Clear();
            long[] array = new long[]{ 1, 2, 3, 4 };
            list.AddRange(array);
            list.AddRange(array);
            WriteList(list);

            list.Remove(1);
            WriteList(list);

            list.RemoveAt(0);
            WriteList(list);

            list.Clear();
            

            Console.ReadKey();
        }

        private static void WriteList(List<long> list)
        {
            Console.WriteLine("--------------------------------");

            for (long i = 0; i < list.Count; i++)
            {
                Console.Write(list[(int)i] + " ");
            }

            Console.WriteLine();
        }
    }
}
