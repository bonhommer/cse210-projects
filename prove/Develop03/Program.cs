using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the name of the book");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the verse number");
        int verse = int.Parse(Console.ReadLine());

        Console.WriteLine("Is this a range of verses? (y/n): ");
        string isRange = Console.ReadLine();

        Reference reference;
        if(isRange.ToLower() == "y")
        {
            Console.Write("Enter the end of verse number");
            int endVerse = int.Parse(Console.ReadLine());
            reference = new Reference(book, chapter, verse, endVerse);
        }
        else{
            reference = new Reference(book, chapter, verse);
        }

        Console.Write("Enter the text of the scripture");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(reference, text);
    }
}