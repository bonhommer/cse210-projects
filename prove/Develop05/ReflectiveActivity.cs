using System.Security.Cryptography.X509Certificates;

public class ReflectiveActivity : Activity
{
    private static int _reflectiveActivityCount = 0;
    public List<string> _prompts;
    public List<string> _questions;

    public ReflectiveActivity()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions  = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        SetName("Reflective");
        SetDescription( "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_prompts.Count);
        return $"{_prompts[randomIndex]}";
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_questions.Count);
        return $"{_questions[randomIndex]}";
        
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write("> ");
        Console.Write(question + " ");
        ShowSpinner(8);
    }
    public void Run()
    {
        _reflectiveActivityCount++;
        DisplayStartingMessage();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        DisplayPrompt();  

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startingTime = DateTime.Now;
        DateTime endTime = startingTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            DisplayQuestions();
            Console.WriteLine();
        }
        
        Console.WriteLine();
        DisplayEndingMessage();
        
    }

     public static int GetReflectiveActivityCount()
    {
        return _reflectiveActivityCount;
    }
} 