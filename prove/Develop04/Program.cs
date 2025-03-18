using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BreathongActivity breathingActivity = new BreathongActivity();
                breathingActivity.InteractBreathing();
                break;
            case "2":
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.InteractReflection();
                break;
            case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.InteractListing();
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}