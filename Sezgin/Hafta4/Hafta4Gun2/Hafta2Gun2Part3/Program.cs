using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hafta2Gun2Part3
{
    class Program
    {
        //Hafta 4, Gün 2, Part 3 <-----> 11.12.2018

        static void Main(string[] args)
        {
            FileInfo NewFile = new FileInfo(@"C:\Test\HedefDizini\NewFile.txt");
            if (NewFile.Exists) // File sınıfı: if(File.Exists(@"C:\Test\NewFile.txt"));
            {
                // Dosya silme işlemi
                NewFile.Delete();
            }

            // Dosya oluşturma
            NewFile.CreateText();
            Console.WriteLine("Oluşturma Tarihi: " + NewFile.CreationTime);
            Console.WriteLine("Son Erişim Tarihi: " + NewFile.LastAccessTime);
            Console.WriteLine("Son Değiştirilme Tarihi: " + NewFile.LastWriteTime);
            Console.WriteLine("Bulunduğu Dizinin Adı: " + NewFile.DirectoryName);
            Console.WriteLine("Dısyanın Adı: " + NewFile.Name);
            Console.WriteLine("Dosyanın Tam Adı: " + NewFile.FullName);
            Console.WriteLine("Dosyanın Uzantısı: " + NewFile.Extension);
            
            if (File.Exists(@"C:\Test\TestDizini\" + NewFile.Name))
                File.Delete(@"C:\Test\TestDizini\" + NewFile.Name);

            // Dosya kopyalama
            NewFile.CopyTo(@"C:\Test\TestDizini\" + NewFile.Name);
            Console.ReadLine();
        }
    }
}
