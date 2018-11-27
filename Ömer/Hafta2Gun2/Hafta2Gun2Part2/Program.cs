using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hafta2Gun2Part2
{
    class Program
    {
        static void ShowArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item?.ToString());
            }
        }
        static int GetIntInput(string question)
        {
            var returnValue = 0;
            while (true)
            {
                Console.Write(question);
                var numberAmountString = Console.ReadLine();
                if (string.IsNullOrEmpty(numberAmountString))
                {
                    Console.WriteLine("Value can not be empty.");
                    continue;
                }
                if (!Regex.IsMatch(numberAmountString, "^[0-9]+$"))
                {
                    Console.WriteLine("Wrong Entry");
                    continue;
                }
                try
                {
                    returnValue = int.Parse(numberAmountString);
                }
                catch
                {
                    Console.WriteLine("Value is either too big or too small");
                    continue;
                }
                break;
            }
            return returnValue;
        }
        static void Main(string[] args)
        {
            var numberAmount = GetIntInput("Amount of numbers to get sum of:");
            var numberArray = new int[numberAmount];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = GetIntInput($"{i + 1}. Number :");
            }
            StringBuilder outputText = new StringBuilder();
            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                outputText.Append(numberArray[i] + " + ");
            }
            outputText.Append(numberArray[numberArray.Length - 1] + " = ");
            Console.WriteLine(outputText.ToString() + numberArray.Sum());
            Console.ReadKey();
        }
    }
}
