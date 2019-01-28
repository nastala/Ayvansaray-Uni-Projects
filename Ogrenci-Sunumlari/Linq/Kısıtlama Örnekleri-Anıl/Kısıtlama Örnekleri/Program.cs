using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kısıtlama_Örnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
           // Bu örnek rakamlardan oluşan bir dizideki 5'den küçük rakamları seçer ve bir foreach döngüsü ile çıktıya yazar.

            int[] Rakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var KucukRakamlar = from Rakam in Rakamlar
                                where Rakam < 5 && Rakam % 2 == 0
                                select Rakam;
            Console.WriteLine("5'den küçük rakamlar...");
           
            foreach (var nrm in KucukRakamlar)
            {
                Console.WriteLine(nrm);
            }
            Console.ReadLine();


            // Aynı örnek, LINQ Yöntem Sözdizimi(LINQ Method Syntax) ile şu şekilde yazılabilir.

            //int[] Rakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var KucukRakamlar = Rakamlar.Where(Rakam => Rakam < 5);
            //Console.WriteLine("5'den küçük rakamlar...");
            //foreach (var Rakam in KucukRakamlar)
            //{
            //    Console.WriteLine(Rakam);
            //}
            //Console.ReadLine();
        }
      

    }
}
