using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4Part3
{
    class Program
    {
        static int nBinary;

        static void Main(string[] args)
        {
            //Hafta 2, Gün 4, Part 3 <-----> 29.11.2018
            int girilenSayi;
            
            girilenSayi = sayiyiGirdir("Aramak istediğiniz sayıyı girin: ");
            sayiyiBinaryAra(girilenSayi, 0, 100);
            Console.WriteLine("{0}. denemede sayı bulundu.", nBinary);

            Console.ReadKey();
        }

        static int sayiyiGirdir(string aciklama)
        {
            Console.Write(aciklama);

            try
            {
                nBinary = 1;
                return Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return sayiyiGirdir("Sayı girmelisiniz! ");
            }
            catch (OverflowException)
            {
                return sayiyiGirdir("Girdiğiniz sayı çok büyük! ");
            }
        }

        static int sayiyiBinaryAra(int sayi, int altLimit, int ustLimit)
        {
            Console.WriteLine("Deneme: {0}, Alt Limit: {1}, Üst Limit: {2}", nBinary, altLimit, ustLimit);

            if (sayi == altLimit)
                return altLimit;
            else if (sayi == ustLimit)
                return ustLimit;
            else
            {
                int ortalama = (altLimit + ustLimit) / 2;

                if (sayi == ortalama)
                    return ortalama;
                else if (sayi > ortalama)
                {
                    nBinary++;
                    return sayiyiBinaryAra(sayi, ortalama, ustLimit);
                }
                else
                {
                    nBinary++;
                    return sayiyiBinaryAra(sayi, altLimit, ortalama);
                }
            }
        }
    }
}
