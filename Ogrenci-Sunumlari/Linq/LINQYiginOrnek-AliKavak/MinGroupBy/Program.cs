using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var SiniflardakiEnDusukOrtalamalar =
                            from Ogrenci in Ogrenciler
                            group Ogrenci by Ogrenci.Sinif into SinifGrubu
                            select new
                            {
                                Sinif = SinifGrubu.Key,
                                EnDusukOrtalama = SinifGrubu.Min(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                            };

            Console.WriteLine("Sınıflardaki en düşük ortalamalar.");

            foreach (var Satir in SiniflardakiEnDusukOrtalamalar)
            {
                Console.WriteLine("{0}. sınıftaki en düşük ortalama = {1}", Satir.Sinif, Satir.EnDusukOrtalama);
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            //Linq Method Syntax
            var SiniflardakiEnDusukOrtalamalarMS =
               Ogrenciler.GroupBy(Ogrenci => Ogrenci.Sinif)
                         .Select(SinifGrubu =>
                                 new {
                                     Sinif = SinifGrubu.Key,
                                     EnDusukOrtalama = SinifGrubu.Min(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                                 }
                                );

            Console.WriteLine("Sınıflardaki en düşük ortalamalar.");

            foreach (var Satir in SiniflardakiEnDusukOrtalamalarMS)
            {
                Console.WriteLine("{0}. sınıftaki en düşük ortalama = {1}", Satir.Sinif, Satir.EnDusukOrtalama);
            }
            Console.ReadLine();
        }
    }
}
