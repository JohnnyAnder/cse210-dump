public class Gathering : Event
{
    public string _forcast;
    public Gathering(string title, string description, string date, string time, string location, string type, string speaker, int capacity, string email, string forcast)
        : base(title, description, date, time, location, "Gathering", speaker, capacity, email, forcast)
    {
        _forcast = forcast;
    }
}