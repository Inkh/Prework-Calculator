using System;
using static System.Console;

namespace PreworkCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to your simple calculator!");
            WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division: ");
            string userInput = ReadLine();
            bool flag = false;

            while (!flag)
            {
                flag = true;
                if (!int.TryParse(userInput, out int result))
                {
                    WriteLine("That wasn't a number... Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division: ");
                    userInput = ReadLine();
                    flag = false;
                }
            }



            switch (int.Parse(userInput))
            {
                case 1:
                    WriteLine("Addition it is! Input two numbers: ");
                    string numOne = ReadLine();
                    try
                    {
                        int.Parse(numOne);
                    }
                    catch (FormatException err)
                    {
                        WriteLine(err.Message);
                    }
                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    string numTwo = ReadLine();
                    WriteLine($"{numOne} + {numTwo} = {Add(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 2:
                    WriteLine("Subtraction it is! Input two numbers: ");
                    numOne = ReadLine();
                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = ReadLine();
                    WriteLine($"{numOne} - {numTwo} = {Subtract(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 3:
                    WriteLine("Multiplication it is! Input two numbers: ");
                    numOne = ReadLine();
                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = ReadLine();
                    WriteLine($"{numOne} * {numTwo} = {Multiply(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 4:
                    WriteLine("Division it is! Input two numbers: ");
                    numOne = ReadLine();
                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = ReadLine();
                    WriteLine($"{numOne} / {numTwo} = {Divide(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                default:
                    WriteLine("You didn't choose any valid functionality. Calculator going back to sleep...");
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
