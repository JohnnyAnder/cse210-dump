public class Entry
{
    public string _givenPrompt;
    public string _entryDateTime;
    public string _entryText;


    // Constructor to create a new entry with the current date/time.
    public Entry(string prompt, string text)
    {
        _givenPrompt = prompt;
        _entryDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _entryText = text;
    }

    // Constructor for loading an entry from a file.
    public Entry(string prompt, string text, string dateTime)
    {
        _givenPrompt = prompt;
        _entryDateTime = dateTime;
        _entryText = text;
    }

    // Displays the entry.
    public void Display()
    {
        Console.WriteLine($"Date: {_entryDateTime}");
        Console.WriteLine($"Prompt: {_givenPrompt}");
        Console.WriteLine($"Entry: {_entryText}");
    }

      // Getters to access private fields
    public string GetDateTime() => _entryDateTime;
    public string GetPrompt() => _givenPrompt;
    public string GetText() => _entryText;
}