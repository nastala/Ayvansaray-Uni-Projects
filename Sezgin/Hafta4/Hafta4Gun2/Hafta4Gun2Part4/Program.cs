using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hafta4Gun2Part4
{
    class Program
    {
        //Hafta 4, Gün 2, Part 4 <-----> 11.12.2018

        static void Main(string[] args)
        {
            string adres = @"C:\Test\TestDizini\NewFile.txt";
            FileStream fs = new FileStream(adres, FileMode.OpenOrCreate);
            FileStream fs2 = new FileStream(adres, FileMode.Append, FileAccess.Write);
            FileStream fs3 = new FileStream(adres, FileMode.Truncate, FileAccess.Write, FileShare.None);
            // FileStream akımının tamoponu temizlenir
            // Hafızadaki tampon bölgedeki bilgileri hemen diske yazar
            fs.Flush();
            // FileStream tarafından kullanılan kaynaklar boşaltılır.
            // Tampon bölgeleri diske yazıp serbest bırakıyor.
            // Sistem kaynaklarını serbest bırakıyor.
            // File close yapılmadan baskları file'ı açıp işlem yapamaz
            fs.Close();

            Console.ReadLine();
        }
    }
}
