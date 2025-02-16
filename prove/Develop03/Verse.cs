public class Verse
{
    public List<Word> _wordlist;

    public Verse(string word)
    {
        _wordlist = word.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void Display()
    {
        foreach (Word _word in _wordlist)
        {
            _word.Display();
            Console.Write(" ");
        }
    }
    public int GetwordCount()
    {
       return _wordlist.Count(word => word.IsRevealed());
    }
    public int GetRevealedCount()
    {
        int count = _wordlist.Count(word => word.IsRevealed());
        return count;
    }
    public void HideWord(int index)
{
    if (index >= 0 && index < _wordlist.Count && _wordlist[index].IsRevealed())
    {
        _wordlist[index].Hide();
    }
}
    public void HideRandomeWord()
    {
        Random rand = new Random();
        List<Word> revealedWords = _wordlist.Where(word => word.IsRevealed()).ToList();

        if (revealedWords.Count > 0)
        {
            int index = _wordlist.IndexOf(revealedWords[rand.Next(revealedWords.Count())]);
            _wordlist[index].Hide();
        }
    }
}