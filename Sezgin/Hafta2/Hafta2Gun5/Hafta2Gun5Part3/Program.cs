using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun5Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            boolKombinasyonu(Int32.Parse(Console.ReadLine()));
            Console.ReadKey();
        }

        static void boolKombinasyonu(int n)
        {
            boolKombinasyonuYrd("", n);
        }

        static void boolKombinasyonuYrd(string oncekiler, int n)
        {
            if(n > 0)
            {
                if (oncekiler != "")
                    oncekiler += ", ";

                boolKombinasyonuYrd(oncekiler + "true", n - 1);
                boolKombinasyonuYrd(oncekiler + "false", n - 1);
            }
            else
            {
                Console.WriteLine(oncekiler);
            }
        }
    }
}
