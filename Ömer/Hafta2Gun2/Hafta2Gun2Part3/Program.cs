using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hafta2Gun2Part3
{
    class Program
    {
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
            var random = new Random();
            var actualNumber = random.Next(1, 11);
            var guessCount = 0;
            Console.WriteLine("Actual Number :" + actualNumber);
            while (true)
            {
                var playerInput = GetIntInput("Your Guess :");
                if (playerInput > 10 || playerInput < 0)
                {
                    Console.WriteLine("Your input must be in range (1-10)");
                    continue;
                }
                if (playerInput == 0)
                {
                    return;
                }
                guessCount++;
                if (playerInput == actualNumber)
                {
                    Console.WriteLine($"You have found it in {guessCount}th try.");
                    while (guessCount != 0)
                    {
                        Console.WriteLine("Do you want to play again (y/n) ?");
                        var answer = Console.ReadKey().KeyChar;
                        switch (answer)
                        {
                            case 'y':
                                guessCount = 0;
                                Console.Clear();
                                break;
                            case 'n':
                                return;
                            default:
                                Console.Clear();
                                Console.WriteLine("You have entered an unknown answer. Try again.");
                                continue;
                        }
                    }
                }
            }
        }
    }
}
