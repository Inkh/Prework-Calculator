using System;

namespace PreworkCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your simple calculator!");
            Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division: ");
            string userInput = Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Divide(int a, int b)
        {
            return (double)a/b;
        }
    }
}
