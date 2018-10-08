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

            //Using a while loop to check for correct format.
            while (!flag)
            {
                //Flip flag to true automatically in case the format is correct.
                flag = true;
                if (!int.TryParse(userInput, out int result))
                {
                    WriteLine("That wasn't a number... Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division: ");
                    userInput = ReadLine();
                    //Flip flag to continue to another iteration of loop.
                    flag = false;
                }
            }


            //Switch case to check what operation the user wants to perform.
            switch (int.Parse(userInput))
            {
                case 1:
                    WriteLine("Addition it is! Input two numbers: ");
                    //Have the helper function check for correct format.
                    string numOne = Checker(ReadLine());

                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    //Helper function on second input.
                    string numTwo = Checker(ReadLine());
                   
                    //Execute appropriate function for each case.
                    WriteLine($"{numOne} + {numTwo} = {Add(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 2:
                    WriteLine("Subtraction it is! Input two numbers: ");
                    numOne = Checker(ReadLine());

                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = Checker(ReadLine());

                    WriteLine($"{numOne} - {numTwo} = {Subtract(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 3:
                    WriteLine("Multiplication it is! Input two numbers: ");
                    numOne = Checker(ReadLine());

                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = Checker(ReadLine());

                    WriteLine($"{numOne} * {numTwo} = {Multiply(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                case 4:
                    WriteLine("Division it is! Input two numbers: ");
                    numOne = Checker(ReadLine());

                    WriteLine($"{numOne} is your first number, now enter the other: ");
                    numTwo = Checker(ReadLine());

                    WriteLine($"{numOne} / {numTwo} = {Divide(int.Parse(numOne), int.Parse(numTwo))}");
                    break;
                default:
                    //If user didn't choose any valid number from menu, exit.
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

        static string Checker(string a)
        //Loops until the user inputs an acceptable format.
        {
            while (!int.TryParse(a, out int res))
            {
                WriteLine("That wasn't a valid number, try again: ");
                a = ReadLine();
            }
            return a;
        }
    }
}
