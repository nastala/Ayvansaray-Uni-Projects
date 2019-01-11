using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grup5_OOP.Classlar;

namespace Grup5_OOP
{
    class Program
    {
        private static Rezervasyon rezervasyon;
        private static Rezervasyon[] mixRezervasyon;

        static void Main(string[] args)
        {
            AnaMenu();
            while (true)
            {
                if (mixRezervasyon != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("1-30 gunluk doluluk durumu <butik otel>");
                    Console.WriteLine("2-30 gunluk doluluk durumu <yat>");
                    Console.WriteLine("3-Bu gün için hızlı rezervasyon <yat-tek yer>");
                    Console.WriteLine("4-Bu gün için hızlı rezervasyon <yat-çift yer>");
                    Console.WriteLine("5-İki tarih arası rezervasyon <yat-çift yer>");
                    Console.WriteLine("6-İki tarih arası rezervasyon <yat-çift yer>");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Console.WriteLine();
                            mixRezervasyon[0].AylikDolulukDurumu();
                            break;
                        case '2':
                            Console.WriteLine();
                            mixRezervasyon[1].AylikDolulukDurumu();
                            break;
                        case '3':
                            Console.WriteLine();
                            mixRezervasyon[0].BugunIcinTekYerlikOtelVeYatYeriRezervasyonu(mixRezervasyon);
                            break;
                        case '4':
                            Console.WriteLine();
                            mixRezervasyon[0].BugunIcinCiftYerlikOtelVeYatYeriRezervasyonu(mixRezervasyon);
                            break;
                    }
                }
                else if (rezervasyon != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine(string.Format("\t{0}", rezervasyon.UygulamaAdi()));
                    Console.WriteLine("1-Bugunku bos yerleri goster");
                    Console.WriteLine("2-30 gunluk doluluk durumu");
                    Console.WriteLine("3-Gun bazinda doluluk oranlari");
                    Console.WriteLine("4-Bugun icin hizli rezervasyon");
                    Console.WriteLine("5-İki tarih arasi rezervasyon");
                    if (!(rezervasyon is ButikOtel))
                    {
                        Console.WriteLine("6-Bugün için hızlı rezervasyon <yan yana iki yer>");
                        Console.WriteLine("7-İki tarih arasi rezervasyon <yan yana iki yer>");
                    }

                    Console.WriteLine("8-Ana menü");
                    Console.WriteLine("0-Gün sonu işlemi");
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '1':
                            Console.WriteLine();
                            rezervasyon.BugunkuBosOdalar();
                            break;
                        case '2':
                            Console.WriteLine();
                            rezervasyon.AylikDolulukDurumu();
                            break;
                        case '3':
                            Console.WriteLine();
                            rezervasyon.GunBazindaDolulukOranlari();
                            break;
                        case '4':
                            Console.WriteLine();
                            rezervasyon.RezervasyonYap();
                            break;
                        case '5':
                            Console.WriteLine();
                            try
                            {
                                Console.Write("Başlangıç tarihini girin(dd-mm-yyyy): ");
                                DateTime dBaslangic = DateTime.Parse(Console.ReadLine());
                                Console.Write("Bitiş tarihini girin(dd-mm-yyyy): ");
                                DateTime dBitis = DateTime.Parse(Console.ReadLine());
                                rezervasyon.RezervasyonYap(dBaslangic, dBitis);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Bir hata meydana geldi. Hata mesajı: " + e.Message);
                            }

                            break;
                        case '6':
                            Console.WriteLine();
                            rezervasyon.RezervasyonYap(DateTime.Today, DateTime.Today, true);
                            break;
                        case '7':
                            Console.WriteLine();
                            try
                            {
                                Console.Write("Başlangıç tarihini girin(dd-mm-yyyy): ");
                                DateTime dBaslangic = DateTime.Parse(Console.ReadLine());
                                Console.Write("Bitiş tarihini girin(dd-mm-yyyy): ");
                                DateTime dBitis = DateTime.Parse(Console.ReadLine());
                                rezervasyon.RezervasyonYap(dBaslangic, dBitis, true);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Bir hata meydana geldi. Hata mesajı: " + e.Message);
                            }
                            break;
                        case '8':
                            AnaMenu();
                            break;
                        case '0':
                            Console.WriteLine();
                            rezervasyon.GunSonuIslemi();
                            break;
                    }
                }
            }
        }

        private static void AnaMenu()
        {
            rezervasyon = null;
            mixRezervasyon = null;
            Console.WriteLine("\n        Rezervasyon Uygulaması");
            Console.WriteLine("1-Otel Rezervasyonu");
            Console.WriteLine("2-Çadır Rezervasyonu");
            Console.WriteLine("3-Yat Rezervasyonu");
            Console.WriteLine("4-Yat ve Otel Rezervasyonu");
            Random random = new Random();
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    rezervasyon = new ButikOtel(random);
                    break;
                case '2':
                    rezervasyon = new Cadir(random);
                    break;
                case '3':
                    rezervasyon = new Yat(random);
                    break;
                case '4':
                    mixRezervasyon = new Rezervasyon[2];
                    mixRezervasyon[0] = new ButikOtel(random);
                    mixRezervasyon[1] = new Yat(random);
                    break;
            }
            if (rezervasyon != null || mixRezervasyon != null)
            {
                if(rezervasyon != null)
                    rezervasyon.RasgeleDoldur();
                else if(mixRezervasyon != null)
                {
                    mixRezervasyon[0].RasgeleDoldur();
                    mixRezervasyon[1].RasgeleDoldur();
                }
            }
            else
                AnaMenu();
        }
    }
}
