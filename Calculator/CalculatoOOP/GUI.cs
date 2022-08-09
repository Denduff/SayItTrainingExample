using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatoOOP
{
    public static class GUI
    {
        public static List<float> Results = new List<float>();
        public static Calculator Calculator = new Calculator();
        private static Operators operators;

        public enum Operators
        {
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4,
            Print = 5
        }

        public static void Show()
        {
            Console.WriteLine("Welcome to Calculator Supreme \n");
            Console.WriteLine("Please choose your desired operation");
            ShowOperations();
            operators = GetOperation();
            if (operators == Operators.Print)
            {
                PrintResults();
                return;
            }
            GetNumbers();
            Calculate();
            Console.Clear();
            Show();
        }

        public static void Calculate()
        {
            switch (operators)
            {
                case Operators.Addition:
                    Calculator.Addition();
                    break;
                case Operators.Subtraction:
                    Calculator.Subtraction();
                    break;
                case Operators.Multiplication:
                    Calculator.Multiplikation();
                    break;
                case Operators.Division:
                    Calculator.Division();
                    break;
                default:
                    throw new Exception("Bruh tf did u put in");
            }
        }

        public static void ShowOperations()
        {
            Console.WriteLine(" 1: Addition \n 2: Subtraction \n 3: Multiplikation \n 4: Division \n 5: Print results");
        }

        public static Operators GetOperation()
        {
            string? input = Console.ReadLine();
            int operation;
            if (int.TryParse(input, out operation))
            {
                if ((Operators)operation != 0)
                {
                    return (Operators)operation;
                }
            }
            if (Enum.IsDefined(typeof(Operators), input))
            {
                return (Operators)Enum.Parse(typeof(Operators), input);
            }

            throw new Exception("Chosen operation was out of range 1-4");
        }

        public static void GetNumbers()
        {
            Console.Clear();
            Console.WriteLine($"You've Chosen {operators}");
            Calculator.tal1 = GetNumber();
            Calculator.tal2 = GetNumber();
        }

        private static float GetNumber()
        {
            Console.WriteLine("Write a number");
            var text = Console.ReadLine();

            float Float;
            if (text == null || !float.TryParse(text, out Float))
            {
                throw new Exception("Input was wrong. Check if your input is valid. Remember it's . and not ,");
            }

            return Float;
        }

        public static void PrintResults()
        {
            Console.Clear();

            for (int i = 0; i < Results.Count; i++)
            {
                Console.WriteLine($"Result #{i + 1} {Results[i]}");
            }
        }
    }
}