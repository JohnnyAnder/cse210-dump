public class Activity
{
    public string _title;
    public string _description;
    public int _duration;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }
    public void GetDuration(int duration)
    {
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }
    public void InteractPrologue()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} activity.");
        Console.WriteLine(_description);
        GetDuration(_duration);
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Timer.PauseWithAnimation("Get ready to begin...", 3);
    }
    public void InteractEpilogue()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed the {_title} activity. It took you {_duration} seconds.");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    
}