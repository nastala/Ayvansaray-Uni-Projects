using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikOtelRezervasyonu1
{
    class Program
    {
        /*
         -Her rezervasyondan sonra oda temizlik i�in bir g�n bo� b�rak�lacak
         ve rezervasyon durumu array'inde 2 ile i�aretlenecek. (0-Bo�, 1-Dolu, 2-Temizlik var)
         -�ki tarih aral���nda rezarvasyon yap�lan program par�as�nda bu yeni �zelli�i yapmay� unutun.
         -Bug�nk� bo� odalar sargusunda temizlik yapilan odalari yanlislikla bos gostersin.
         ve bir sonraki gun temizlik icin bos birakilabilir mi diye kontrol etmesin
         -Gun sonu isleminde son gun icin rezerve edilmis odan�n sonraki gunune otomatik olarak temizlik gunu eklenir.
             */
        /*
         Rezervasyon yapma i�lemini bir classa toplay�n ve b�t�n hatalar� d�zeltin.
         Genel hatlar�yla bir rezervasyon class� olacak, 2 bir tane rezervasyon enum� bo� dolu, temizlik, 3 bir tane de rastgele doldur methodu yap�n,verilen arrayi girin
         son a�ama bir tane method, bug�nk� bo� odalar, ikinci method ayl�k doluluk durumu, ���nc� method bug�n i�in h�zl� rezervasyon, iki tarih aras� rezervasyon,
         bug�n i�in h�zl� -> iki tarih aras� rezervasyon �a��racak tek sat�r,
         g�n sonu i�lemi methodu
         Rezervasyon durumu arrayi private olsun
             */

        /*
         Rezervasyondan inherit ederk �ad�rrezervasyon, oda kelimelerinin �ad�r olarak, ana ba�l�k �ad�r rezervasyonu
             */
        const int odaSayisi = 10;
        const int gunSayisi = 30;
        static int[,] rezervasyonDurumu = new int[odaSayisi, gunSayisi];

        static void Main(string[] args)
        {
            Classlar.Rezervasyon rezervasyon = new Classlar.Rezervasyon();
            Classlar.Cadir cadir = new Classlar.Cadir();
            cadir.AylikDolulukDurumu();
            cadir.GunBazindaDoluluk();
            Console.ReadKey();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("        �ad�r Yeri Rezervasyonu");
                Console.WriteLine("1-Bugunku bos yerleri goster");
                Console.WriteLine("2-30 gunluk doluluk durumu");
                Console.WriteLine("3-G�n baz�nda doluluk oranlar�");
                Console.WriteLine("4-Bug�n i�in h�zl� rezervasyon <k���k �ad�r>");
                Console.WriteLine("5-�ki tarih aras� h�zl� rezervasyon <k���k �ad�r>");
                Console.WriteLine("6-Bug�n i�in h�zl� rezervasyon <b�y�k �ad�r>");
                Console.WriteLine("7-�ki tarih aras� h�zl� rezervasyon <b�y�k �ad�r>");
                Console.WriteLine("8-Gun sonu islemi");

                DateTime now = DateTime.Today;
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        cadir.BugunkuBosOdalar();
                        break;
                    case '2':
                        cadir.AylikDolulukDurumu();
                        break;
                    case '3':
                        cadir.GunBazindaDoluluk();
                        break;
                    case '4':
                        cadir.KucukCadirRezervasyon(now, now);
                        break;
                    case '5':
                        try
                        {
                            Console.Write("\n\t Ba�lang�� Tarihini girin(dd-mm-yyyy): ");
                            DateTime dBaslangic = DateTime.Parse(Console.ReadLine());
                            Console.Write("\n\t Biti� Tarihini girin(dd-mm-yyyy): ");
                            DateTime dBitis = DateTime.Parse(Console.ReadLine());
                            cadir.KucukCadirRezervasyon(dBaslangic, dBitis);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n\t Bir Hata Meydana Geldi " + e.Message);
                        }
                        break;
                    case '6':
                        cadir.BuyukCadirRezervasyon(now, now);
                        break;
                    case '7':
                        try
                        {
                            Console.Write("\n\t Ba�lang�� Tarihini girin(dd-mm-yyyy): ");
                            DateTime dBaslangic = DateTime.Parse(Console.ReadLine());
                            Console.Write("\n\t Biti� Tarihini girin(dd-mm-yyyy): ");
                            DateTime dBitis = DateTime.Parse(Console.ReadLine());
                            cadir.BuyukCadirRezervasyon(dBaslangic, dBitis);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n\t Bir Hata Meydana Geldi " + e.Message);
                        }
                        break;
                    case '8':
                        cadir.GunSonu();
                        break;
                }
            }
            //rezervasyonDurumu[0, 0] = 1;
            //rezervasyonDurumu[0, 1] = 2;
            //rezervasyonDurumu[0, 5] = 1;
            //rezervasyonDurumu[0, 6] = 2;
            //rezervasyonDurumu[1, 7] = 1;
            //rezervasyonDurumu[1, 8] = 2;
            //rezervasyonDurumu[2, 9] = 1;
            //rezervasyonDurumu[2, 10] = 2;
            //rezervasyonDurumu[5, 15] = 1;
            //rezervasyonDurumu[5, 16] = 2;
            //rezervasyonDurumu[8, 20] = 1;
            //rezervasyonDurumu[8, 21] = 2;
            //rezervasyonDurumu[0, 27] = 1;
            //rezervasyonDurumu[0, 28] = 2;
            //rezervasyonDurumu[9, 29] = 1;
            //rezervasyonDurumu[4, 0] = 2;
            //rezervasyonDurumu[5, 1] = 1;
            //rezervasyonDurumu[5, 2] = 2;

            //DateTime currentDate = DateTime.Today;
            //while (true)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("        Butik Otel Rezervasyonu");
            //    Console.WriteLine("1-Bugunku bos odalari goster");
            //    Console.WriteLine("2-30 gunluk doluluk durumu");
            //    Console.WriteLine("3-Bugun icin hizli rezervasyon");
            //    Console.WriteLine("4-Iki tarih arasi rezervasyon");
            //    Console.WriteLine("5-Gun sonu islemi");

            //    switch (Console.ReadKey().KeyChar)
            //    {
            //        case '1':
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("Bugunku bos odalar");
            //                bool bosOdaYok = true;
            //                for (int i=0; i<odaSayisi; i++)
            //                {
            //                    if (rezervasyonDurumu[i,0] != 1)
            //                    {
            //                        bosOdaYok = false;
            //                        Console.WriteLine(i+1);
            //                    }
            //                }
            //                if (bosOdaYok)
            //                    Console.WriteLine("Bugun icin bos oda yok");
            //                break;
            //            }
            //        case '2':
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("30 gunluk doluluk durumu");
            //                Console.Write("      ");
            //                for (int j = 0; j < gunSayisi; j++)
            //                {
            //                    Console.Write(" {0:00}", currentDate.AddDays(j).Day);
            //                }
            //                Console.WriteLine();
            //                for (int i = 0; i < odaSayisi; i++)
            //                {
            //                    Console.Write("Oda {0:00}",i+1);
            //                    for (int j = 0; j < gunSayisi; j++)
            //                    {
            //                        if (rezervasyonDurumu[i, j] == 0)
            //                            Console.Write(" - ");
            //                        else if (rezervasyonDurumu[i, j] == 1)
            //                            Console.Write(" D ");
            //                        else
            //                            Console.Write(" x ");
            //                    }
            //                    Console.WriteLine();
            //                }
            //                break;
            //            }
            //        case '3':
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("Bugun icin hizli rezervasyon");
            //                bool bosOdaYok = true;
            //                for (int i = 0; i < odaSayisi; i++)
            //                {
            //                    if (rezervasyonDurumu[i, 0] == 0 && rezervasyonDurumu[i, 1] == 0)
            //                    {
            //                        bosOdaYok = false;
            //                        rezervasyonDurumu[i, 0] = 1;
            //                        rezervasyonDurumu[i, 1] = 2;
            //                        Console.WriteLine("{0} numarali oda sizin icin ayrildi", i+1);
            //                        break;
            //                    }
            //                }
            //                if (bosOdaYok)
            //                    Console.WriteLine("Bugun icin bos oda yok");
            //                break;
            //            }
            //        case '4':
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("Iki tarih arasi rezervasyon");
            //                DateTime date1 = DateTime.Today;
            //                DateTime date2 = DateTime.Today;
            //                try
            //                {
            //                    Console.Write("Rezervasyon baslangic tarihi (gg/aa/yyyy): ");
            //                    string baslangicTarihi = Console.ReadLine();
            //                    date1 = Convert.ToDateTime(baslangicTarihi);

            //                    Console.Write("Rezervasyon bitis tarihi (gg/aa/yyyy): ");
            //                    string bitisTarihi = Console.ReadLine();
            //                    date2 = Convert.ToDateTime(bitisTarihi);
            //                }
            //                catch (FormatException)
            //                {
            //                    Console.WriteLine("Tarih formatina dikkat ediniz");
            //                }
            //                if (date1 < currentDate)
            //                {
            //                    Console.WriteLine("Baslangic tarih bugunden kucuk olamaz");
            //                    break;
            //                }
            //                if (date2 < date1)
            //                {
            //                    Console.WriteLine("Bitis tarihi baslangic tarihinden kucuk olamaz");
            //                    break;
            //                }
            //                if ((date1 - currentDate).Days >= gunSayisi)
            //                {
            //                    Console.WriteLine("Baslangic tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi-1));
            //                    break;
            //                }
            //                if ((date2 - currentDate).Days >= gunSayisi)
            //                {
            //                    Console.WriteLine("Bitis tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi-1));
            //                    break;
            //                }
            //                Console.WriteLine("{0} {1} {2}", currentDate, date1, date2);
            //                int gun1 = (date1 - currentDate).Days;
            //                int gun2 = (date2 - currentDate).Days;
            //                bool bosOdaYok = true;
            //                for (int i = 0; i < odaSayisi; i++)
            //                {
            //                    bool odaMusait = true;
            //                    for (int j = gun1; j <= gun2; j++)
            //                    {
            //                        if (rezervasyonDurumu[i, j] == 1)
            //                        {
            //                            odaMusait = false;
            //                            break;
            //                        }
            //                    }
            //                    if (odaMusait)
            //                    {
            //                        for (int j = gun1; j <= gun2; j++)
            //                        {
            //                            rezervasyonDurumu[i, j] = 1;
            //                        }
            //                        bosOdaYok = false;
            //                        Console.WriteLine("{0} numarali oda sizin icin ayrildi", i + 1);
            //                        break;
            //                    }
            //                }
            //                if (bosOdaYok)
            //                        Console.WriteLine("Bu tarih araliginda bos oda yok");
            //                break;
            //            }
            //        case '5':
            //            {
            //                currentDate = currentDate.AddDays(1);
            //                Console.WriteLine();
            //                Console.WriteLine("Gun sonu islemi");
            //                for (int i = 0; i < odaSayisi; i++)
            //                {
            //                    for (int j = 0; j < gunSayisi-1; j++)
            //                    {
            //                        rezervasyonDurumu[i, j] = rezervasyonDurumu[i, j + 1];
            //                        if (j == (gunSayisi - 2))
            //                        {
            //                            if (rezervasyonDurumu[i, j] == 1)
            //                            {
            //                                rezervasyonDurumu[i, j + 1] = 2;
            //                            }
            //                            else
            //                                rezervasyonDurumu[i, j + 1] = 0;
            //                        }
            //                    }
            //                }
            //                break;
            //            }
            //    } 
            //}
        }
    }
}
