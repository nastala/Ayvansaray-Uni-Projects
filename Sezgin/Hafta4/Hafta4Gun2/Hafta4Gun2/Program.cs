using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hafta4Gun2
{
    class Program
    {
        //Hafta 4, Gün 2, Part 1, File Create, Move, Remove, etc. <-----> 11.12.2018


        static void Main(string[] args)
        {
            string path = @"C:\Test\TestDizini";
            string target = @"C:\Test\HedefDizini";
            try
            {
                // Exist Static Methodu ile dizinin var olup olmadığının kontrolü.
                if (!Directory.Exists(path))
                {
                    // CreateDirectory methodu ile dizin oluşturma işlemi
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Oluşturma Tarihi:" + Directory.GetCreationTime(path));
                    Console.WriteLine("Son Erişim Tarihi: " + Directory.GetLastAccessTime(path));
                    Console.WriteLine("Son Değiştirilme Tarihi: " + Directory.GetLastWriteTime(path));
                    Console.WriteLine("Bulunduğu Dizinin Adı: " + Directory.GetParent(path));
                    Console.ReadLine();
                }

                if (Directory.Exists(target))
                {
                    // Delete methodu ile dizin silme işlemi
                    Directory.Delete(target, true);
                }

                // Move methodu ile dizini taşıma işlemi
                Directory.Move(path, target);
                // GetDirectories ile dizindeki klasörlerin seçimi
                string[] directories = Directory.GetDirectories(target);
                foreach(string dir in directories)
                {
                    Console.WriteLine(dir);
                }
                // Yeni bir Metin Belgesi oluşturma
                File.CreateText(target + @"\NewFile.txt");
                // GetFiles ile dizindeki dosyaların seçimi
                Console.WriteLine("{0} dizinindeki dosya sayısı: {1}", target, Directory.GetFiles(target).Length);
            }
            catch (Exception exc)
            {
                Console.Clear();
                Console.WriteLine("İşlem başarısız! Hata mesajı: {0}", exc.Message);
            }

            Console.ReadLine();
        }
    }
}
