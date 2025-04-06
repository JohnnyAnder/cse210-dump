using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Science of Cooking", "Learn the science behind cooking.", "04-07-2025", "7pm", "The Kitchen","", "Dr. John Doe", 100,"","");
        Gathering gathering = new Gathering("Community Picnic", "Join us for a fun community picnic.", "04-15-2025", "4pm", "Porter Park", "", "", 0, "", "Sunny");
        Reception reception = new Reception("Anderson Wedding", "Join us in celebration of the union of Paige Johnson and Johnny Anderson.", "07-12-2025", "6pm", "Grand Tetons Golf Clubhouse","", "", 0,"MyEmailHere@Email.com","");

        Event event1 = lecture;
        Event event2 = gathering;
        Event event3 = reception;

        event1.DisplayShort();
        Console.WriteLine();
        event1.DisplayStandard();
        Console.WriteLine();
        event1.DisplayFull();
        Console.WriteLine();

        Thread.Sleep(2000);

        Console.WriteLine();
        event2.DisplayShort();
        Console.WriteLine();
        event2.DisplayStandard();
        Console.WriteLine();
        event2.DisplayFull();
        Console.WriteLine();

        Thread.Sleep(2000);

        Console.WriteLine();
        event3.DisplayShort();
        Console.WriteLine();
        event3.DisplayStandard();
        Console.WriteLine();
        event3.DisplayFull();

    }
}