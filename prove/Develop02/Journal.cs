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
        public void loadFromFile(string fileName)
    {
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            Entry newEntry = null;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

                
                if (line.StartsWith("Date :"))
                {
                    if (newEntry != null)
                    {
                        
                        _entries.Add(newEntry);
                    }

                  
                    string[] parts = line.Split(new[] { "- Prompt: " }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        newEntry = new Entry
                        {
                            _date = parts[0].Replace("Date : ", "").Trim(), 
                            _promptText = parts[1].Trim() 
                        };
                    }
                }
                else if (newEntry != null)
                {
                   
                    newEntry._entryText += line + Environment.NewLine; 
                }
            }

           
            if (newEntry != null)
            {
                _entries.Add(newEntry);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please check the file name and try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while loading the journal: " + ex.Message);
        }
    }
}