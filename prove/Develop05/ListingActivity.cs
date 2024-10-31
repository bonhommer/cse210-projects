using System.Diagnostics;
using System.Dynamic;

public class ListingActivity : Activity
{
    private static int _listingActivityCount = 0;
    int _count;
    List<string> _prompts;
    List<String> listFromUser = new List<string>();
    public ListingActivity()
    {
        _count = 0;
        SetName("Listing");
        SetDescription("This activity will help you reflect your life by having you list as many things as you can in a certain area");
        // _name = "Listing";
        // _description = "This activity will help you reflect your life by having you list as many things as you can in a certain area";
        _prompts = new List<string>()
        {
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are people that you appreciate?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }


    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[randomIndex]} ---");
    }

    public List<string> GetListFromUser()
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {

            Console.Write("> ");
            listFromUser.Add(Console.ReadLine());
        }

        return listFromUser;
       
    }
    public void Run()
    {
        _listingActivityCount++;
        DisplayStartingMessage();
   // _duration = int.Parse(Console.ReadLine())         // Console.WriteLine();

        // Console.Write("How long, in seconds, would you like for your session? ");

        
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to te following prompt:");


        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        GetListFromUser();
        _count = listFromUser.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items");
        Console.WriteLine();

        DisplayEndingMessage();
    }

    public static int GetListingActivityCount()
    {
        return _listingActivityCount;
    }
}