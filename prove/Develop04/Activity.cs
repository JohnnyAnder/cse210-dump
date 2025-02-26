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
        console.WriteLine("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        _duration = duration;
    }
    public void InteractPrologue()
    {
        Console.WriteLine($"Welcome to the {_title} activity.");
        Console.WriteLine(_description);
        GetDuration(_duration);
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Get ready to begin...");
    }
    public void InteractEpilogue()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed the {_title} activity.");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    public class BreathongActivity : Activity
    {
        public BreathongActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }
        public void InteractBreathing()
        {
            InteractPrologue();
            Console.WriteLine("Starting the breathing activity...");
            // Add breathing logic here
            InteractEpilogue();
        }
    }
    public class ReflectionActivity : Activity
    {
        public ReflectionActivity() : base("Reflection", "This activity will help you reflect on your day and think about what you are grateful for.")
        {
        }
        public void InteractReflection()
        {
            InteractPrologue();
            Console.WriteLine("Starting the reflection activity...");
            // Add reflection logic here
            InteractEpilogue();
        }
    }
    public class ListingActivity : Activity
    {
        public ListingActivity() : base("Listing", "This activity will help you list things you are grateful for.")
        {
        }
        public void InteractListing()
        {
            InteractPrologue();
            Console.WriteLine("Starting the listing activity...");
            // Add listing logic here
            InteractEpilogue();
        }
    }

}