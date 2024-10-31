using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{   
    private static int _breathingActivityCount = 0;
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void Run()
    {
        _breathingActivityCount++;
        DisplayStartingMessage();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DateTime startingTime = DateTime.Now;
        DateTime endTime = startingTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);

            Console.WriteLine();
            
            Console.Write("Breath out...");
            ShowCountDown(4);

            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

     public static int GetBreathingActivityCount()
    {
        return _breathingActivityCount;
    }
}
