public class Timer
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
    static int PauseWithAnimation(string message, int seconds)
    {
        Console.WriteLine(message);
        int remaining = seconds;
        while (remaining > 0)
        {
            Console.Write($"\r{remaining} seconds remaining...");
            System.Threading.Thread.Sleep(1000);
            remaining--;
        }
        Console.WriteLine("\nTime's up!");
        return remaining;
    }
}