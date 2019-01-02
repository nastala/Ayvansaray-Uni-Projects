using System;

namespace Hafta6Gun3_OOP5
{
    class Program
    {
        // Primitive Değişkenler
        static void Main(string[] args)
        {
            ConsoleColor onRenk = ConsoleColor.White;
            ConsoleColor arkaRenk = ConsoleColor.DarkYellow;
            Console.BackgroundColor = arkaRenk;
            Console.ForegroundColor = onRenk;

            int x = 100;
            decimal y = 100;
            bool deger = true;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
