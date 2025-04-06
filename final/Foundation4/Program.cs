using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("April 1st, 2025",  60, "Running", 8);
        activities.Add(run);

        Cycling cycling = new Cycling("April 3rd, 2025", 35, "Cycling", 19);
        activities.Add(cycling);

        Swimming swimming = new Swimming("April 4th, 2025", 45, "Swimming", 25);
        activities.Add(swimming);
        
        Console.WriteLine("Your recent activities this week were:\n");

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}