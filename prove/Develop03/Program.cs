using System;

// To exceed the core requirments, my programm ask the user for the information instead of storing a scripture for them in the program. the program ask him/her the informations, and help him/her to memorize the scripture.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the name of the book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the verse number: ");
        int verse = int.Parse(Console.ReadLine());

        Console.WriteLine("Is this a range of verses? (y/n): ");
        string isRange = Console.ReadLine();

        Reference reference;
        if(isRange.ToLower() == "y")
        {
            Console.Write("Enter the end of verse number: ");
            int endVerse = int.Parse(Console.ReadLine());
            reference = new Reference(book, chapter, verse, endVerse);
        }
        else{
            reference = new Reference(book, chapter, verse);
        }

        Console.Write("Enter the text of the scripture: ");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(reference, text);
        string isContinue;
        do
        {
            int numberToHide = 1;
            scripture.hideRandomWords(numberToHide);
            Console.Clear();

            Console.WriteLine(scripture.getDisplayText());

            if (scripture.isCompletlyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish");
            isContinue = Console.ReadLine();

        }while (isContinue.ToLower() != "quit");
        
    }
}