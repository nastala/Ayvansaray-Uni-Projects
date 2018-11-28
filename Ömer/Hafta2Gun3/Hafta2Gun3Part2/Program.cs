using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun3Part2
{
    public interface IOperation
    {
        float Calculate();
    }

    public abstract class OneValueOperation
    {
        protected static float GetFloatInput(string question)
        {
            var returnValue = 0f;
            while (true)
            {
                Console.Write(question);
                var numberAmountString = Console.ReadLine();
                if (string.IsNullOrEmpty(numberAmountString))
                {
                    Console.WriteLine("Value can not be empty.");
                    continue;
                }
                //if (!Regex.IsMatch(numberAmountString, "^[0-9.]+$"))
                //{
                //    Console.WriteLine("Wrong Entry");
                //    continue;
                //}
                if (!float.TryParse(numberAmountString, out returnValue))
                {
                    Console.WriteLine("Value is not correct");
                    continue;
                }
                break;
            }
            return returnValue;
        }
        protected float Number1, Number2;

        protected OneValueOperation()
        {
            Console.WriteLine();
            Number1 = GetFloatInput("First Value :");
        }
    }

    public abstract class TwoValueOperation : OneValueOperation
    {
        protected TwoValueOperation() : base()
        {
            Number2 = GetFloatInput("Second Value :");
        }
    }
    class Add : TwoValueOperation, IOperation
    {
        public float Calculate()
        {
            return Number1 + Number2;
        }
    }

    class Subtract : TwoValueOperation, IOperation
    {
        public float Calculate()
        {
            return Number1 - Number2;
        }
    }

    class Multiply : TwoValueOperation, IOperation
    {
        public float Calculate()
        {
            return Number1 * Number2;
        }
    }
    class Divide : TwoValueOperation, IOperation
    {
        public float Calculate()
        {
            return Number1 / Number2;
        }
    }

    class SquareRoot : OneValueOperation, IOperation
    {
        public float Calculate()
        {
            return (float)Math.Sqrt((int)Number1);
        }
    }
    class Calculator
    {
        private IOperation _currentOperation;
        public float GetResult => _currentOperation.Calculate();

        public IOperation Operation
        {
            set { _currentOperation = value; }
        }

        public Calculator(IOperation currentOperation)
        {
            _currentOperation = currentOperation;
        }
    }

    class Calculation
    {
        private readonly Calculator _calculator;
        public Calculation(char operationChar)
        {
            switch (operationChar)
            {
                case '+':
                    _calculator = new Calculator(new Add());
                    break;
                case '-':
                    _calculator = new Calculator(new Subtract());
                    break;
                case '*':
                    _calculator = new Calculator(new Multiply());
                    break;
                case '/':
                    _calculator = new Calculator(new Divide());
                    break;
                case 'r':
                    _calculator = new Calculator(new SquareRoot());
                    break;
                default:
                    throw new ArgumentException("Given operation char is not valid.", nameof(operationChar));
            }
        }

        public float GetResult
        {
            get
            {
                if (_calculator != null)
                {
                    return _calculator.GetResult;
                }
                throw new NullReferenceException("This object's initializing failed");
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Calculation calculation;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter desired operation :");
                try
                {
                    calculation = new Calculation(Console.ReadKey().KeyChar);
                    Console.WriteLine("Result :" + calculation.GetResult);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    continue;
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
