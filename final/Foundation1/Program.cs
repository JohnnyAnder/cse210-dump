using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Han Bro", 420);
        video1._Comments.Add(new Comment("Steve", "Great video!"));
        video1._Comments.Add(new Comment("Alex", "Very informative."));
        video1._Comments.Add(new Comment("Charlie", "I learned a lot."));

        video1.DisplayVideoInfo();

        Thread.Sleep(2000);

        Console.WriteLine();
        Console.WriteLine();

        Video video2 = new Video("Advanced C#", "Fane Toe", 562);
        video2._Comments.Add(new Comment("Dave", "Excellent content!"));
        video2._Comments.Add(new Comment("Eve", "Well explained concepts."));
        video2._Comments.Add(new Comment("Frank", "This is exactly what I needed."));

        video2.DisplayVideoInfo();

        Thread.Sleep(2000);

        Console.WriteLine();
        Console.WriteLine();

        Video video3 = new Video("C# in Depth", "Jason Doneous", 999);
        video3._Comments.Add(new Comment("Gina", "A must-watch for every programmer."));
        video3._Comments.Add(new Comment("Hank", "Incredible depth of knowledge."));
        video3._Comments.Add(new Comment("Ivy", "This video changed my perspective on C#."));
        video3._Comments.Add(new Comment("Jack", "I wish I had found this video earlier."));

        video3.DisplayVideoInfo();
    }
}
