using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 4, Fibonacci Örneği <-----> 29.11.2018

            int[] dizi = new int[100];
            dizi[1] = 1;
            dizi[2] = 1;
            for(int i = 1; i <= 50; i++)
            {
                if(dizi[i] <= 100)
                {
                    dizi[i + 1] = dizi[i] + dizi[i - 1];
                    Console.WriteLine(dizi[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
