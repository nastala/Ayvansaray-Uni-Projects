using System;

namespace Hafta6Gun3_OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Classlar.Yazici yazici = new Classlar.Yazici();
            yazici.Yazdir(5);
            yazici.Yazdir("test");
            Console.ReadLine();
        }
    }
}
