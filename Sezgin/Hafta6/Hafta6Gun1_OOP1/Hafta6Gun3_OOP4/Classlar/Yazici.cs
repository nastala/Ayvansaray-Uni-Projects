using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta6Gun3_OOP4.Classlar
{
    class Yazici
    {
        public void Yazdir(int i)
        {
            Console.WriteLine("Sayısal değer yazdırılıyor: {0}", i);
        }

        public void Yazdir(string s)
        {
            Console.WriteLine("Metinsel değer yazdırılıyor: {0}", s);
        }
    }
}
