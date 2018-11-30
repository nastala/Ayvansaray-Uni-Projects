using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun5Part2
{
    class Program
    {
        static Random r;
        static int satirSayisi;
        static void Main(string[] args)
        {
            //Hafta 2, Gün 5, Part 2 <-----> 30.11.2018
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ÇALIŞMIYOR !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //boolean kombinasyonu 
            r = new Random();
            satirSayisi = 0;
            string sKombinasyonlar = "";
            int n = sayiyiGirdir("Lütfen sayıyı giriniz: ");
            
            sKombinasyonlar = kombinasyonlariBul2(n, sKombinasyonlar);
            Console.WriteLine(sKombinasyonlar);
            Console.ReadLine();
        }

        static string kombinasyonlariBul(int n, string kombinasyonlar)
        {
            if (satirSayisi == Math.Pow(2, n))
                return kombinasyonlar;
            else
            {
                string kombinasyon = "";
                int random;
                for(int i = 0; i < n; i++)
                {
                    random = r.Next(0, 2);
                    if (random == 0)
                        kombinasyon += "false, ";
                    else
                        kombinasyon += "true, ";
                }

                if (!kombinasyonlar.Contains(kombinasyon))
                {
                    satirSayisi++;
                    kombinasyonlar += kombinasyon + "\n";
                }

                return kombinasyonlariBul(n, kombinasyonlar);
            }
        }

        static int sayiyiGirdir(string aciklama)
        {
            int girilenSayi;
            Console.Write(aciklama);
            try
            {
                girilenSayi = Int32.Parse(Console.ReadLine());
                return girilenSayi;
            }
            catch (FormatException)
            {
                return sayiyiGirdir("Sayı girmelisiniz! ");
            }
            catch (OverflowException)
            {
                return sayiyiGirdir("Girdiğiniz sayı çok büyük! ");
            }
        }

        static string kombinasyonlariBul2(int n, string kombinasyonlar)
        {
            double toplamSatirSayisi = Math.Pow(2, n);
            if (satirSayisi == toplamSatirSayisi)
                return kombinasyonlar;
            else
            {
                string kombinasyon = "";
                for (int i = 0; i < n; i++)
                {
                    if (satirSayisi != 0 && i == (n - satirSayisi) || i == (n - (satirSayisi % 3)))
                        kombinasyon += "false, ";
                    else if (satirSayisi == toplamSatirSayisi - 1)
                        kombinasyon += "false, ";
                    else
                        kombinasyon += "true, ";
                }

                kombinasyonlar += kombinasyon + "\n";
                satirSayisi++;
                return kombinasyonlariBul2(n, kombinasyonlar);
            }
        }
    }
}
