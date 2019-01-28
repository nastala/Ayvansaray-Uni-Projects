using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSequence
{
    public static class OzelSilsileIslecleri
    {
        public static IEnumerable<int> CustomMethod(this IEnumerable<int> birinci,
                                                     IEnumerable<int> ikinci,
                                                     Func<int, int, int> fonksiyon)
        {

            IEnumerator<int> Sayici1 = birinci.GetEnumerator();

            IEnumerator<int> Sayici2 = ikinci.GetEnumerator();

            while (Sayici1.MoveNext() && Sayici2.MoveNext())
            {
                yield return fonksiyon(Sayici1.Current, Sayici2.Current);
            }
        }

        public static int CustomCount(this string str)
        {
            return str.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] VectorA = { 0, 2, 4, 5, 6 };

            int[] VectorB = { 1, 3, 5, 7, 8 };

            IEnumerable<int> CarpimDizisi = VectorA.CustomMethod(VectorB, (a, b) => a * b);

            int SkalerCarpim = CarpimDizisi.Sum();

            Console.Write("Çarpım dizisi : ");

            foreach (int Carpim in CarpimDizisi)
            {
                Console.Write(Carpim);
                Console.Write(" ");
            }

            Console.WriteLine();

            Console.WriteLine("Vektörlerin skaler çarpımı = {0}", SkalerCarpim);
            Console.ReadLine();

            //------------------------------------------

            string myString = "I'm a string";
            int customCount = myString.CustomCount();
            Console.WriteLine("myString's length: {0}", customCount);
            Console.ReadLine();
        }
    }
}
