using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GubreliSu
{
    class Program
    {
        static void Main(string[] args)
        {
            //    cBitki b1 = new cBitki();
            //    b1.Beslenme = "gübre";
            //    cBitki b2 = b1;
            //    b2.Beslenme = "su";
            //    Console.WriteLine(b1.Beslenme);

            var bitkiler = new cBitki[] 
            {
                new cBitki
                {
                    Beslenme = "gübre"
                },
                new cBitki
                {
                    Beslenme = "su"
                }
            };

            cBitki[] bitkilerClone = (cBitki[])bitkiler.Clone();
            bitkilerClone[0] = new cBitki(){ Beslenme = "su" };

            Console.WriteLine(bitkiler[0].Beslenme);
            Console.ReadKey();
        }
    }
}
