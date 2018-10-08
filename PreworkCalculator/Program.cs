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
            int result;

            switch (int.Parse(userInput))
            {
                case 1:
                    Console.WriteLine("Addition it is! Input two numbers: ");
                    string numOne = Console.ReadLine();
                    Console.WriteLine($"{numOne} is your first number, now enter the other: ");
                    string numTwo = Console.ReadLine();
                    Console.WriteLine($"{numOne} + {numTwo} = {Add(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 2:
                    Console.WriteLine("Subtraction it is! Input two numbers: ");
                    numOne = Console.ReadLine();
                    Console.WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = Console.ReadLine();
                    Console.WriteLine($"{numOne} - {numTwo} = {Subtract(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 3:
                    Console.WriteLine("Multiplication it is! Input two numbers: ");
                    numOne = Console.ReadLine();
                    Console.WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = Console.ReadLine();
                    Console.WriteLine($"{numOne} * {numTwo} = {Multiply(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 4:
                    Console.WriteLine("Division it is! Input two numbers: ");
                    numOne = Console.ReadLine();
                    Console.WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = Console.ReadLine();
                    Console.WriteLine($"{numOne} / {numTwo} = {Divide(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
            }
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
