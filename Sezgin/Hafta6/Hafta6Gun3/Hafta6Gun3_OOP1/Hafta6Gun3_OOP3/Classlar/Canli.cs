using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta6Gun3_OOP3.Classlar
{
    enum CanliTip
    {
        Insan,
        Hayvan
    }

    enum Hareket
    {
        Havla,
        KuyrukSalla,
        PatiUzat
    }

    class Canli
    {
        static public void Konus(CanliTip tip, string ifade)
        {
            Console.WriteLine("{0} der ki: {1}", tip, ifade);
        }

        static public void Konus(string ifade)
        {
            Console.WriteLine(ifade);
        }

        static public void Konus(CanliTip tip, Hareket hareket)
        {
            Console.WriteLine("{0} şunu yaptı: {1}", tip, hareket);
        }
    }
}
