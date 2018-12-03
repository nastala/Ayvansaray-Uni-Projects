using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hafta3Gun1
{
    class Program
    {
        //Hafta 3, Gün 1, Part 1, Inner Exception <-----> 03.12.2018

        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("Enter first number: ");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result = {0}", Result);
                }
                catch(Exception ex)
                {
                    const string filePath = @"C:\Users\iau\Documents\GitHub\my-log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, please try again");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                        //throw new FileNotFoundException(filePath + " is not present");
                        //throw ex;
                    }
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("Current exception = {0}", exc.GetType().Name);
                if(exc.InnerException != null)
                {
                    Console.WriteLine("Inner exception = {0}", exc.InnerException.GetType());
                }
            }

            Console.ReadKey();
        }
    }
}
