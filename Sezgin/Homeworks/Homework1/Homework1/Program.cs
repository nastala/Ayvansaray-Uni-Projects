using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework-1

            //-------------------------------------------------------------------------------------------

            //Fal baktırmak isim, doğum tarih ilk -> 
            //1. aşama -> isim ve doğum tarihi(DateTime) girerken girilen ismin rakam içermediğinden ve tarihin geçerli bir formatta yazıldığından emin olun. (Kullanıcıyı tekrar giriş yaptır.) Ayrıca fal baktıracak kişi > 18, değilse programı sonlandır.
            //2. aşama -> çin burcu, tarihi çin burcunda kontrol et, burcunu ekrana yaz
            //1960 fare, 61 öküz ,62 kaplan, 63 tavşan, 64 ejderha, 65 yılan, 66 at, 67 keçi, 68 maymun, 69 horoz, 70 köpek, 71 domuz (mod 12)
            //3. aşama -> kişinin bir sonraki doğum gününün haftanın hangi günü olduğunu yaz.

            //-------------------------------------------------------------------------------------------

            string sIsim, sBurc, bsDogumGunu;
            DateTime dogumTarihi, bsDogumTarihi;
            Regex regex = new Regex("[0-9]");
            int iYas;

            //İsim kontrolü
            while (true)
            {
                Console.Write("İsminizi giriniz: ");
                sIsim = Console.ReadLine();

                if (!regex.IsMatch(sIsim))
                    break;
                else
                    Console.WriteLine("İsminiz herhangi bir sayı içermemelidir.");
            }

            //Doğum tarihi kontrolü
            while (true)
            {
                try
                {
                    Console.Write("Doğum tarihinizi giriniz: ");
                    dogumTarihi = DateTime.Parse(Console.ReadLine());

                    if (!(dogumTarihi.Year >= DateTime.Today.Year))
                        break;
                    else
                        Console.WriteLine("Hatalı bir tarih girdiniz. (Ör: DD/MM/YYYY)");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Hatalı bir tarih girdiniz. (Ör: DD/MM/YYYY)");
                }
            }

            //Yaş kontrolü
            iYas = DateTime.Today.Year - dogumTarihi.Year;
            if (iYas <= 18)
            {
                Console.WriteLine("Yaşı 18'den küçük olanlar fal baktıramaz.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //Çin burcunun bulunması
            switch (dogumTarihi.Year % 12)
            {
                case 0:
                    sBurc = "maymun";
                    break;
                case 1:
                    sBurc = "horoz";
                    break;
                case 2:
                    sBurc = "köpek";
                    break;
                case 3:
                    sBurc = "domuz";
                    break;
                case 4:
                    sBurc = "fare";
                    break;
                case 5:
                    sBurc = "öküz";
                    break;
                case 6:
                    sBurc = "kaplan";
                    break;
                case 7:
                    sBurc = "tavşan";
                    break;
                case 8:
                    sBurc = "ejderha";
                    break;
                case 9:
                    sBurc = "yılan";
                    break;
                case 10:
                    sBurc = "at";
                    break;
                case 11:
                    sBurc = "keçi";
                    break;
                default:
                    sBurc = "";
                    break;
            }

            bsDogumTarihi = new DateTime(DateTime.Today.Year, dogumTarihi.Month, dogumTarihi.Day);
            if (bsDogumTarihi >= DateTime.Today)
            {
                if(bsDogumTarihi == DateTime.Today)
                    Console.WriteLine("Nice senelere");
            }
            else
                bsDogumTarihi = new DateTime(DateTime.Today.Year + 1, dogumTarihi.Month, dogumTarihi.Day);

            //Günün Türkçeleştirilmesi
            switch (bsDogumTarihi.DayOfWeek)
            {
                case System.DayOfWeek.Monday:
                    bsDogumGunu = "Pazartesi";
                    break;
                case System.DayOfWeek.Tuesday:
                    bsDogumGunu = "Salı";
                    break;
                case System.DayOfWeek.Wednesday:
                    bsDogumGunu = "Çarşamba";
                    break;
                case System.DayOfWeek.Thursday:
                    bsDogumGunu = "Perşembe";
                    break;
                case System.DayOfWeek.Friday:
                    bsDogumGunu = "Cuma";
                    break;
                case System.DayOfWeek.Saturday:
                    bsDogumGunu = "Cumartesi";
                    break;
                case System.DayOfWeek.Sunday:
                    bsDogumGunu = "Pazar";
                    break;
                default:
                    bsDogumGunu = "";
                    break;
            }

            //Kapanış
            Console.WriteLine("İsim: {0}, Doğum Tarihi: {1:dd/MM/yyyy}, Burcu: {2}, Bir Sonraki Doğum Günü: {3}", sIsim, dogumTarihi, sBurc, bsDogumGunu);

            Console.ReadKey();
        }
    }
}
