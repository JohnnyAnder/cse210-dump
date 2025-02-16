public class Word
{
    public string _word;
    public bool _revealed;
    
    public Word(string _word)
    {
        this._word = _word;
        this._revealed = true;
    }
    public void Display()
    {
        if (_revealed)
        {
            Console.Write(_word);
        }
        else
        {
            Console.Write(new string('_', _word.Length));
        }
    }
    public void Hide()
    {
        _revealed = false;
    }
    public bool IsRevealed()
    {
        if (_revealed == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}