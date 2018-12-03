using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework2
{
    class Program
    {
        //Homework - 2

        public static int koltumSecim, i;
        public static string[] economy = { "", "", "", "", "", "", "", "", "", "", "", "" };
        public static string[] business = { "", "", "", "", "", "", "", "" };
        public static string tus, isim;
        public static Regex regex = new Regex("[0-9]");

        static void Main(string[] args)
        {
            try
            {
                anaMenu();
                isimAl();
                rezervasyon();
                Console.ReadKey();
                Main(null);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("İstenmedik bir hata ile karşılaştık. Lütfen yetkili kişi ile irtibata geçiniz...");
                Main(null);
            }
        }

        private static void anaMenu()
        {
            Console.WriteLine("Press 1 for Economy Class");
            Console.WriteLine("Press 2 for Business Class");
            i = Int32.Parse(Console.ReadKey().KeyChar.ToString());
            if(i != 1 && i != 2)
            {
                Console.Clear();
                Console.WriteLine("You entered a wrong number!");
                anaMenu();
            }
        }

        private static void isimAl()
        {
            Console.Write("\n\nEnter your name: ");
            isim = Console.ReadLine();
            if (regex.IsMatch(isim))
            {
                Console.WriteLine("Digit number is forbidden!");
                isimAl();
            }
        }

        private static bool koltukKontrol()
        {
            string sOutput = "";
            Console.WriteLine("a: available, f: full");
            if(i == 1)
            {
                for(int j = 0; j < economy.Length; j++)
                {
                    if (!string.IsNullOrEmpty(economy[j]))
                        sOutput += (j + 1) + ": f, ";
                    else
                        sOutput += (j + 1) + ": a, ";
                }
            }
            else if (i == 2)
            {
                for(int j = 0; j < business.Length; j++)
                {
                    if (!string.IsNullOrEmpty(business[j]))
                        sOutput += (j + 1) + ": f, ";
                    else
                        sOutput += (j + 1) + ": a, ";
                }
            }
            sOutput = sOutput.Substring(0, sOutput.Length - 2);
            Console.WriteLine(sOutput);

            Console.Write("\nPlease enter the seat number: ");
            koltumSecim = Int32.Parse(Console.ReadLine());
            koltumSecim -= 1;
            if(i == 1)
            {
                if (string.IsNullOrEmpty(economy[koltumSecim]))
                {
                    economy[koltumSecim] = isim;
                    return true;
                }
            }
            else if (i == 2)
            {
                if (string.IsNullOrEmpty(business[koltumSecim]))
                {
                    business[koltumSecim] = isim;
                    return true;
                }
            }

            return false;
        }

        private static void rezervasyon()
        {
            if (koltukKontrol())
                Console.WriteLine("You've booked the seat successfully\n");
            else
            {
                Console.Clear();
                Console.WriteLine("The seat is already taken!\n");
                koltukKontrol();
            }
        }
    }
}
