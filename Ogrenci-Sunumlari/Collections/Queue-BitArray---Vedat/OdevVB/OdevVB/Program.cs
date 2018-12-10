using System;
using System.Collections;

namespace OdevVB
{
    class Program
    {
        static void Main(string[] args)
        {
            // ilk giren ilk çıkar
            Queue kuyruk = new Queue(); // tip bağımsız 

            kuyruk.Enqueue("Serdar Yılmaz");
            kuyruk.Enqueue(5);
            kuyruk.Enqueue(5.6);
            foreach (object a in kuyruk)
                Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine();

            object silinen = kuyruk.Dequeue();
            Console.WriteLine("Silinen Öğe:" + silinen);
            foreach (object b in kuyruk)
                Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
