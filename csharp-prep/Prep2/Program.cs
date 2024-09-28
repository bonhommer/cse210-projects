using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? (Just type the number) ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);
        string letter = "";
        if (number >= 90)
        {
            letter = "A";
            // Console.WriteLine("Congratulations, you pass the class!");
        }
        else if (number >=80)
        {
            letter = "B";
            // Console.WriteLine("Congratulations, you pass the class!");
        }
        else
        {
            if (number >= 70)
            {
                letter = "C";

                // Console.WriteLine("Congratulations, you pass the class!");
            }
            else if (number >=60)
            {
                letter = "D";

                // Console.WriteLine("Unfortunately, your grade should be at least 70%. Next time try to do your best");
            }
            else{
                letter = "F";
                // Console.WriteLine("Unfortunately, your grade should be at least 70%. Next time try to do your best");
            }
        }
        int lastDigit = number % 10;
        string sign = "";
        if (lastDigit >= 7 && !(letter == "A") && !(letter =="F"))
        {
            sign = "+";
        }
        else if (lastDigit <3 && !(letter == "F"))
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you pass the class!");
        }
        else{
            Console.WriteLine("Unfortunately, your grade should be at least 70%. Next time try to do your best");
        }
        
    }
}