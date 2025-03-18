using System;
public class BreathongActivity : Activity
{
    public BreathongActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void InteractBreathing()
    {
        InteractPrologue();
        Console.WriteLine("Starting the breathing activity...");
        Timer.PauseWithNumber("Get ready to begin...", 3);
        Console.Clear();

        //logic
        int sequencenum = _duration / 10;
        for (int i = 0; i < sequencenum; i++)
        {
            Timer.PauseWithNumber("Breathe in...", 4);
            Timer.PauseWithNumber("Hold your breath...", 2);
            Timer.PauseWithNumber("Breathe out...", 4);
            Console.WriteLine("");
        }
        InteractEpilogue();
    }
}
