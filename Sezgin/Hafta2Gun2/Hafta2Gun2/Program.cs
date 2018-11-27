using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hafta 2, Gün 2 <-----> 27.11.2018

            //-------------------------------------------------------------------

            //bool bCheck = true;
            //int iSayac;
            //Random r;
            //int iSayi;
            //int girilenSayi;
            //char cDevam;

            //while (bCheck)
            //{
            //    r = new Random();
            //    iSayi = r.Next(1, 10);
            //    iSayac = 1;

            //    while (true)
            //    {
            //        Console.Write("Tahmin ettiğiniz sayıyı giriniz: ");
            //        try
            //        {
            //            girilenSayi = Int32.Parse(Console.ReadLine());

            //            if (girilenSayi < 0 || girilenSayi > 10)
            //            {
            //                Console.WriteLine("Girdiğiniz sayı 0'dan küçük, 10'dan büyük olamaz");
            //                continue;
            //            }

            //            if (girilenSayi == 0)
            //            {
            //                Console.WriteLine("Uygulama sonlandırıldı.");
            //                Console.ReadKey();
            //                Environment.Exit(0);
            //            }
            //            else if (girilenSayi == iSayi)
            //            {
            //                Console.WriteLine("------------> TEBRİKLER! {0}. denemenizde sayıyı buldunuz <------------", iSayac);
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("{0}. tahmininizde sayıyı bulamadınız.", iSayac);
            //                iSayac++;
            //            }
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Lütfen sayı giriniz");
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("Girilen sayi çok büyük!");
            //        }
            //    }

            //    while (true)
            //    {
            //        Console.Write("\nTekrar oynamak ister misiniz?(E/H): ");
            //        cDevam = Console.ReadKey().KeyChar;
            //        if (cDevam.Equals('H') || cDevam.Equals('h'))
            //        {
            //            bCheck = false;
            //            break;
            //        }
            //        else if (cDevam.Equals('E') || cDevam.Equals('e'))
            //        {
            //            bCheck = true;
            //            break;
            //        }
            //        else
            //            Console.WriteLine("\nYanlış bir tuşa bastınız.");
            //    }

            //    Console.WriteLine("");
            //}

            //-------------------------------------------------------------------

            //bool bCheck = true;
            //int arrayBoyutu = 0;
            //int iAttemps = 0;
            //int[] iSayilar;
            //int girilenSayi;
            //int sayilarinToplami = 0;
            //string sOutput = "";

            //while (bCheck)
            //{
            //    while (true)
            //    {
            //        Console.Write("Kaç adet sayı gireceksiniz: ");

            //        try
            //        {
            //            arrayBoyutu = Int32.Parse(Console.ReadLine());
            //            iAttemps = 0;
            //            break;
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Lütfen bir sayı giriniz.");
            //            iAttemps++;

            //            if (iAttemps >= 5)
            //            {
            //                Console.WriteLine("Çok fazla sayıda yanlış giriş yaptınız. Uygulamayı kapatmak için herhangi bir tuşa basınız.");
            //                Console.ReadKey();
            //                Environment.Exit(0);
            //            }
            //        }
            //        catch(OverflowException)
            //        {
            //            Console.WriteLine("Çok büyük bir sayı girdiniz!");
            //        }
            //    }

            //    if (arrayBoyutu <= 0)
            //        continue;

            //    iSayilar = new int[arrayBoyutu];
            //    for (int i = 0; i < arrayBoyutu; i++)
            //    {
            //        Console.Write("{0}. sayıyı giriniz: ", (i + 1));

            //        try
            //        {
            //            girilenSayi = Int32.Parse(Console.ReadLine());
            //            iSayilar[i] = girilenSayi;
            //            iAttemps = 0;
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Lütfen bir sayı giriniz.");
            //            iAttemps++;
            //            i -= 1;

            //            if (iAttemps >= 5)
            //            {
            //                Console.WriteLine("Çok fazla sayıda yanlış giriş yaptınız. Uygulamayı kapatmak için herhangi bir tuşa basınız.");
            //                Console.ReadKey();
            //                Environment.Exit(0);
            //            }
            //        }
            //        catch (OverflowException)
            //        {
            //            i -= 1;
            //            Console.WriteLine("Çok büyük bir sayı girdiniz!");
            //        }
            //    }

            //    Console.WriteLine("--------------------------");

            //    Console.WriteLine("Girdiğiniz sayılar: ");
            //    foreach (int iSayi in iSayilar)
            //    {
            //        Console.WriteLine(iSayi);
            //        sayilarinToplami += iSayi;
            //        sOutput += iSayi + " + ";
            //    }

            //    sOutput = sOutput.Substring(0, sOutput.Length - 3);

            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("Sayıların toplamı: " + sayilarinToplami);

            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine(sOutput + " = " + sayilarinToplami);

            //    Console.Write("\nDevam etmek istiyor musunuz?(Y/N): ");
            //    if (Console.ReadKey().KeyChar.Equals('N'))
            //        bCheck = false;

            //    Console.WriteLine();
            //}

            //-------------------------------------------------------------------

            //string[] sGunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            ////Array.Clear(sGunler, 0, 3);
            //for (int i = 0; i < sGunler.Length; i++)
            //    Console.WriteLine(sGunler[i]);

            //Console.WriteLine("--------------------------");

            //string[] sGunler2 = (string[])sGunler.Clone();

            //sGunler[0] = "Monday";
            //sGunler[1] = "Tuesday";
            //sGunler[2] = "Wednesday";
            //sGunler[3] = "Thursday";
            //sGunler[4] = "Friday";
            //sGunler[5] = "Saturday";
            //sGunler[6] = "Sunday";

            //Console.WriteLine("sGunler; ");
            //foreach (string gun in sGunler)
            //    Console.WriteLine(gun);

            //Console.WriteLine("--------------------------");

            //Console.WriteLine("Clone; ");
            //foreach (string gun in sGunler2)
            //    Console.WriteLine(gun);

            //Console.WriteLine("--------------------------");

            //string[] sGunler3 = new string[5];
            //Array.Copy(sGunler, sGunler3, 5);
            //Console.WriteLine("Copy; ");
            //foreach (string gun in sGunler3)
            //    Console.WriteLine(gun);

            //Console.WriteLine("--------------------------");

            //Array.Sort(sGunler);
            //Console.WriteLine("Sort; ");
            //foreach (string gun in sGunler)
            //    Console.WriteLine(gun);

            //Console.WriteLine("--------------------------");

            //Array.Reverse(sGunler);
            //Console.WriteLine("Reverse; ");
            //foreach (string gun in sGunler)
            //    Console.WriteLine(gun);

            //-------------------------------------------------------------------

            Console.ReadKey();
        }

    }
}
