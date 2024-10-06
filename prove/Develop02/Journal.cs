public class Journal
{
    public  List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty");
        }
        else
        {
            foreach(Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void saveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date : { entry._date} - Prompt: {entry._promptText}");
                outputFile.WriteLine(entry._entryText);;
            }
        }
    }

    public void loadFromFile( string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        else
        {
            Console.WriteLine($"File '{file}' not found.");
        }
    }
}