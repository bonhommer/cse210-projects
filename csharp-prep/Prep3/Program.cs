using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        int userGuess = 0;
        int i = 0; 
        
        while (userGuess != magicNumber)
        {
            string suffix;
                            
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            i += 1;

            int lastDigit = i % 10;
            if (lastDigit== 1 && !(i==11))
            {
                suffix = "st"; 
            }
            else if (lastDigit == 2)
            {
                suffix = "nd";
            }
            else if (lastDigit == 3)
            {
                suffix = "rd";
            }
            else
            {
                suffix = "th";
            }  

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guess the write number on your {i}{suffix} try.");
            }
        }
    }
}