using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nums = new[] { 1, 2, 3, 4 };
            int[] nums = new[] { 1, 2, 3, 4 };
            int sum = nums.Aggregate((a, b) => a + b);
            Console.WriteLine("Dizideki Sayıların Toplamı : "+sum); // output: 10 (1+2+3+4)
            Console.WriteLine("---------------------------------------------------");

            double[] OndalikSayilar = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double Carpim = OndalikSayilar.Aggregate((SonSonuc, SiradakiDiziElemani) => SonSonuc * SiradakiDiziElemani);

            Console.WriteLine("Dizideki sayıların çarpımı = {0}", Carpim);

            Console.WriteLine("---------------------------------------------------");

            int[] multipliers = new[] { 10, 20, 30, 40 };
            int  multiplied = multipliers.Aggregate(5, (a, b) => a * b);
            Console.WriteLine(multiplied); //Output 1200000 ((((5*10)*20)*30)*40)
            Console.WriteLine("---------------------------------------------------");

            double BaslangicBakiyesi = 100.0;

            int[] CekilmekIstenenler = { 20, 10, 40, 50, 10, 70, 30 };

            double Bakiye =
                            CekilmekIstenenler.Aggregate(BaslangicBakiyesi,
                                                         (SonBakiye, SiradakiTutar) =>
                                                                (
                                                                 (SiradakiTutar <= SonBakiye) ?
                                                                 (SonBakiye - SiradakiTutar) :
                                                                  SonBakiye
                                                                )
                                                        );

            Console.WriteLine("Son kalan: {0}", Bakiye);
            Console.ReadLine();
        }
    }
}
