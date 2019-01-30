using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinGroupBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var SiniflardakiEnDusukOrtalamaliOgrenciler =
                            from Ogrenci in Ogrenciler
                            group Ogrenci by Ogrenci.Sinif into SinifGrubu
                            let EnDusukOrtalama = SinifGrubu.Min(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                            select new
                            {
                                Sinif = SinifGrubu.Key,
                                EnDusukOrtalamaliOgrenciler = SinifGrubu.Where(Ogrenci => Ogrenci.Ortalama == EnDusukOrtalama)
                            };

            Console.WriteLine("Sınıflardaki en düşük ortalamalı öğrenciler.");

            foreach (var Satir in SiniflardakiEnDusukOrtalamaliOgrenciler)
            {
                Console.WriteLine("{0}. sınıftaki en düşük ortalamalı öğrenci ortalaması {1} olan {2} isimli öğrencidir.",
                                  Satir.Sinif,
                                  Satir.EnDusukOrtalamaliOgrenciler.First().Ortalama,
                                  Satir.EnDusukOrtalamaliOgrenciler.First().Adi);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            // let'in yordam karşılığı olmadığından Grup ve Gruptaki en düşük ortalamadan yeni bir isimsiz
            // nesne oluşturulup bu nesne üzerinden Select çalıştırılarak aynı sonuca gidildi.

      // Linq Method SynTax

            var SiniflardakiEnDusukOrtalamaliOgrencilerMS =
                                Ogrenciler.GroupBy(Ogrenci => Ogrenci.Sinif)
                                .Select(SinifGrubu => new {
                                    SinifGrubu = SinifGrubu,
                                    EnDusukOrtalama = SinifGrubu.Min(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                                })
                                .Select(Satir => new
                                {
                                    Sinif = Satir.SinifGrubu.Key,
                                    EnDusukOrtalamaliOgrenci = Satir.SinifGrubu.Where(Ogrenci => Ogrenci.Ortalama == Satir.EnDusukOrtalama)
                                });

            Console.WriteLine("Sınıflardaki en düşük ortalamalı öğrenciler.");

            foreach (var Satir in SiniflardakiEnDusukOrtalamaliOgrencilerMS)
            {
                Console.WriteLine("{0}. sınıftaki en düşük ortalamalı öğrenci ortalaması {1} olan {2} isimli öğrencidir.",
                                  Satir.Sinif,
                                  Satir.EnDusukOrtalamaliOgrenci.First().Ortalama,
                                  Satir.EnDusukOrtalamaliOgrenci.First().Adi);
            }
            
            Console.ReadLine();
        }
    }
}
