using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Date : {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }

}