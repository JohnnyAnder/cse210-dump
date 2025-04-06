public class Reception : Event
{
    
    public string _email;

    public Reception(string title, string description, string date, string time, string location, string type, string speaker, int capacity, string email, string forcast)
        : base(title, description, date, time, location, "Reception", speaker, capacity, email, forcast)
    {
        _email = email;
    }
}