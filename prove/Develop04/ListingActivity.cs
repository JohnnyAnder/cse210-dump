using System.ComponentModel;

public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    public void InteractListing()
    {
        InteractPrologue();
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("You may begin in:");
        Timer.PauseWithNumber("", 5);
        Console.Clear();
        string prompt = Prompt();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        List<string> entries = new List<string>();
        int numitems = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Clear();
            Console.WriteLine($"You have entered {numitems} items.");
            Console.WriteLine("You may continue to enter items.");
            Console.WriteLine(prompt);
            string answer = Console.ReadLine();
            entries.Add(answer);
            numitems ++;
        }
        Console.Clear();
        Console.WriteLine($"You entered {numitems} items.");
        Console.WriteLine("Here is your list:");
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
        Timer.PauseWithAnimation("Get ready to end...", 10);
        InteractEpilogue();
    }
    private string Prompt()
    {
        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random random = new Random();
        int randomIndex = random.Next(prompts.Length);
        string prompt = prompts[randomIndex];
        return prompt;
    }
}
