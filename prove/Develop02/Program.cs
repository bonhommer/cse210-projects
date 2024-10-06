using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Console.WriteLine("Welcome to the Journal Program!");

        PromptGenerator prompt = new PromptGenerator();
        prompt.AddPrompt("Who was the most interesting person I interacted with today?");
        prompt.AddPrompt("What was the best part of my day?");
        prompt.AddPrompt("How did I see the hand of the Lord in my life today?");
        prompt.AddPrompt("What was the strongest emotion I felt today?");
        prompt.AddPrompt("If I had one thing I could do over today, what would it be?");
        // Adding more prompts as exceeding requirements
        prompt.AddPrompt("What could I do to become a better person?");
        prompt.AddPrompt("Who was the last person I said something nice to?");
        prompt.AddPrompt("What should I do to reach my main goal as soon as possible?");
        
        Journal journal = new Journal();
       
        
        do
        { 
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. save");
            Console.WriteLine("5. Quit");
            Console.Write("what would you like to do? ");
            choice = Console.ReadLine();

        // if statements to handle the choices of the user
        if (choice == "1" || choice.ToLower() == "write")
        {
            // code to choose a random prompt
           string randomPrompt = prompt.getRandomPrompt();
           Console.WriteLine(randomPrompt);
           Console.Write("> ");

           Entry newEntry = new Entry(); 
           newEntry._promptText = randomPrompt;
           newEntry._entryText = Console.ReadLine();

        // Add the user enter in the journal
           journal.AddEntry(newEntry);
           
        }

        else if (choice == "2" || choice.ToLower() == "display")
        {
            journal.DisplayAll();
        }

        else if (choice == "3" || choice.ToLower() == "load")
        {
            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();
            journal.loadFromFile(fileName);
            Console.WriteLine();
        }

        else if (choice == "4" || choice.ToLower() == "save")
        {
            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();
            journal.saveToFile(fileName);
            Console.WriteLine();
        }

        else if (choice == "5" || choice.ToLower() == "quit")
        {
            break;
        }
        else
        {
            Console.WriteLine("Choose one of the options above");
        }
        Console.WriteLine();
    }while(choice != "5" && choice.ToLower() != "quit");
    }
    
}