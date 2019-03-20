using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            EldeIsleminiBul(sayi1, sayi2);

            Console.ReadKey();
        }

        private static void EldeIsleminiBul(int sayi1, int sayi2)
        {
            char[] sayi1Chars = sayi1.ToString().Reverse().ToArray();
            char[] sayi2Chars = sayi2.ToString().Reverse().ToArray();
            int maxLength = sayi1Chars.Length > sayi2Chars.Length ? sayi1Chars.Length : sayi2Chars.Length;

            if (sayi1Chars.Length < 1 || sayi2Chars.Length < 1)
            {
                Console.WriteLine("Toplam Elde Sayisi: 0");
                return;
            }

            int eldeSayisi = 0;
            int eldeDegeri = 0;
            for (int i = 0; i < maxLength; i++)
            {
                int a = 0;
                int b = 0;

                try
                {
                    a = Convert.ToInt32(sayi1Chars[i].ToString());
                }
                catch (Exception)
                {
                }

                try
                {
                    b = Convert.ToInt32(sayi2Chars[i].ToString());
                }
                catch (Exception)
                {
                }

                if (a + b + eldeDegeri >= 10)
                {
                    eldeSayisi++;
                    eldeDegeri = (a + b + eldeDegeri) / 10;
                }
                else
                    eldeDegeri = 0;
            }

            Console.WriteLine("Toplam Elde Sayisi: {0}", eldeSayisi);
        }
    }
}
