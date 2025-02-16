using System.ComponentModel.DataAnnotations;

public class ScriptureToMemorize
{
    public ScriptureCitation _reference;
    public List<Verse> _verses;

    public ScriptureToMemorize()
    {

    }
    public ScriptureToMemorize(ScriptureCitation citation, List<Verse> verses)
    {
       _reference = citation;
        _verses = verses;
    }
    public void Display()
    {
        _reference.Display(); Console.WriteLine();

    foreach (Verse verse in _verses)
    {
        verse.Display();
        Console.WriteLine();
    }

    }
    public void HideThreeWords()
{
    int wordsHidden = 0;
    Random rand = new Random();

    while (wordsHidden < 3)
    {
        // Pick a random verse
        Verse verse = _verses[rand.Next(_verses.Count)];

        // Get a list of words that are still visible
        List<Word> visibleWords = verse._wordlist.Where(word => word.IsRevealed()).ToList();

        // If there are no visible words left in this verse, skip it
        if (visibleWords.Count == 0)
            continue;

        // Pick a random word from the visible words and hide it
        visibleWords[rand.Next(visibleWords.Count)].Hide();
        wordsHidden++;
    }
}
    public int GetTotalRevealedWords()
{
    return _verses.Sum(verse => verse.GetRevealedCount());
}
}