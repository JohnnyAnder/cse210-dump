public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _Comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int CommentCalc()
    {
        return _Comments.Count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {CommentCalc()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _Comments)
        {
            comment.DisplayComment();
        }
    }   
}