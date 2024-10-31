using System;
using System.Xml.Serialization;

// for exceed requirements, I add an option where the program keep track of how many times the user do each activity, and print the count at the end
class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while(choice.ToLower() != "quit" && choice != "4")
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing Activity");
            Console.WriteLine("  2. Start reflecting Activity");
            Console.WriteLine("  3. Start listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Console.Clear();
            if(choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            else if(choice == "2")
            {
                ReflectiveActivity reflectiveActivity = new ReflectiveActivity();
                reflectiveActivity.Run();
            }

            else if(choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            if (choice == "4")
            {
                break;
            }
        }

        // Keeping log of how many times the user do each activity
        Console.WriteLine("Activity summary: ");
        Console.WriteLine($"Breathing Activity performed {BreathingActivity.GetBreathingActivityCount()} time(s)");
        Console.WriteLine($"Reflective Activity performed {ReflectiveActivity.GetReflectiveActivityCount()} time(s)");
        Console.WriteLine($"Listing Activity performed {ListingActivity.GetListingActivityCount()} time(s)");
    }
}