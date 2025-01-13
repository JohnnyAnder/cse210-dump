using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int x = rnd.Next(1, 101);
        string answer = "n";
        
        while (answer == "n")
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int y = int.Parse(guess);

            if (x == y)
            {
                Console.WriteLine("You guessed it!");
                answer = "y";
            }
            else if (x > y)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}