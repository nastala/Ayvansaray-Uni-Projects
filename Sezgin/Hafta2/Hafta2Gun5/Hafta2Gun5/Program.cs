using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 5, Part 1 <-----> 30.11.2018

            int iFaktoriyel, iSonuc;
            iFaktoriyel = sayiyiGirdir("Lütfen faktoriyelini almak istediğiniz sayıyı giriniz: ");

            iSonuc = recursiveFaktoriyel(iFaktoriyel);
            Console.WriteLine("Recursive Faktoriyel Sonuc: " + iSonuc);

            iSonuc = whileFaktoriyel(iFaktoriyel);
            Console.WriteLine("While Faktoriyel Sonuc: " + iSonuc);

            Console.ReadKey();
        }

        static int sayiyiGirdir(string aciklama)
        {
            int girilenSayi;
            Console.Write(aciklama);
            try
            {
                girilenSayi = Int32.Parse(Console.ReadLine());
                return girilenSayi;
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

        static int recursiveFaktoriyel(int sayi)
        {
            if (sayi <= 1)
                return 1;
            else
                return sayi * recursiveFaktoriyel(sayi - 1);
        }

        static int whileFaktoriyel(int sayi)
        {
            int iSonuc = 1;
            while(sayi > 1)
            {
                iSonuc *= sayi;
                sayi--;
            }

            return iSonuc;
        }
    }
}
