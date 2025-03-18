class Timer
{
    static DateTime _targetTime;
    static int Set(int seconds)
    {
        _targetTime = DateTime.Now.AddSeconds(seconds);
        return seconds;
    }
    static bool IsExpired()
    {
        return DateTime.Now >= _targetTime;
    }
    public static void PauseWithAnimation(string message, int seconds)
    {
        Console.WriteLine(message);
        int remaining = seconds;
        while (remaining > 0)
        {
           Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("x");

            Thread.Sleep(500);
            Console.Write("\b \b");

            remaining --;
        }
    }
    public static void PauseWithNumber(string message, int seconds)
    {
    int remaining = seconds;
    Console.Write(message + " " + remaining);
    int digits = remaining.ToString().Length;

    while (remaining > 0)
        {
        Thread.Sleep(1000);
        remaining--;
        
        // Move cursor back and overwrite the previous number with spaces
        Console.Write("\r" + message + " " + new string(' ', digits)); 
        
        // Move cursor back again and write the updated number
        Console.Write("\r" + message + " " + remaining);

        digits = remaining.ToString().Length; // Update digit count in case of length change
        }
    
    Console.WriteLine(); // Move to next line after countdown
    }

}