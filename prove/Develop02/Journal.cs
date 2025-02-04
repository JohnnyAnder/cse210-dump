public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    // Adds a new entry to the journal.
    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
        Console.WriteLine("Entry added successfully!");
    }

    // Displays all entries in the journal.
    public void Display()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("No entries available.");
            return;
        }

        Console.WriteLine("\nYour Journal Entries:");
        foreach (Entry entry in _entryList)
        {
            entry.Display();
            Console.WriteLine("-------------------");
        }
    }

    // Saves the journal entries to a file.
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList)
            {
                writer.WriteLine($"{entry.GetDateTime()}|{entry.GetPrompt()}|{entry.GetText()}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    // Loads journal entries from a file.
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entryList.Clear();
            foreach (string line in File.ReadAllLines(filename))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entryList.Add(new Entry(parts[1], parts[2], parts[0]));
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}