using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public string getRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(_prompts.Count);
            string randomPrompt = _prompts[randomIndex];
            return randomPrompt; 
        }
        else 
        {
            return "The _prompts list is empty";
        }
    }
}