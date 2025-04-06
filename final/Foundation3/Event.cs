public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _location;
    private string _type;
    private string _speaker;
    private int _capacity;
    private string _email;
    private string _forcast;


    public Event(string title, string description, string date, string time, string location, string type, string speaker, int capacity, string email, string forcast)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _location = location;
        _type = type;
        _speaker = speaker;
        _capacity = capacity;
        _email = email;
        _forcast = forcast;
    }
    
    public void DisplayStandard()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Location: {_location}");
    }
    public void DisplayFull()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Location: {_location}");
        if (_type == "Lecture")
        {
            Console.WriteLine($"Speaker: {_speaker}");
            Console.WriteLine($"Capacity: {_capacity}");
        }
        else if (_type == "Gathering")
        {
            Console.WriteLine($"Forecast: {_forcast}");
        }
        else if (_type == "Reception")
        {
            Console.WriteLine($"RSVP Email: {_email}");
        }
    }
    public void DisplayShort()
    {
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}