using System;

namespace Hafta6Gun3_OOP2
{
    class Program
    {
        // OOP-2
        static void Main(string[] args)
        {
            Insan Mert = new Insan();
            Kopek Pasha = new Kopek();

            Mert.el = 2;
            Mert.ayak = 2;
            Pasha.ayak = 4;
            Mert.Konus();
            Pasha.Havla();
        }
    }
}
