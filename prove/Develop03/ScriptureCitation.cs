public class ScriptureCitation
{
    public string _book;
    public int _chapter;
    public int _firstVerse;
    public int _lastVerse;

    public ScriptureCitation(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = firstVerse;
    }
    public ScriptureCitation(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public void Display()
    {
        if (_firstVerse != _lastVerse)
        {
            Console.Write($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_firstVerse}");
        }
    }
}