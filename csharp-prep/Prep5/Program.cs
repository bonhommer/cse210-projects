using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        static void main()
        {
            Displaymessage();
            string username = PromptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(username, square);
        }

        static void Displaymessage()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("What's your favorite number? ");
            int usernumber = int.Parse(Console.ReadLine());
            return usernumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string username, int square)
        {
            Console.WriteLine($"{username}, the square of your number is {square}");
        }
        main();
    }
}