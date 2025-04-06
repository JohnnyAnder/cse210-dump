using System;
public class Lecture : Event
{
    public string _speaker;
    public int _capacity;

    public Lecture(string title, string description, string date, string time, string location, string type, string speaker, int capacity, string email, string forcast)
        : base(title, description, date, time, location, "Lecture", speaker, capacity, email, forcast)
    {
        _speaker = speaker;
        _capacity = capacity;

    }
    
}