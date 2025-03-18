public class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
    public void InteractReflection()
    {
        InteractPrologue();
        Console.WriteLine("Starting the reflection activity...");
        Console.Clear();
        Prompt();
        Timer.PauseWithNumber("Question in:", _duration/2);
        Console.Clear();
        questions();
        Timer.PauseWithNumber("Think about your answer...", _duration/2);
        InteractEpilogue();
    }
    private void Prompt()
    {
        string[] prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        Random random = new Random();
        int randomIndex = random.Next(prompts.Length);
        string prompt = prompts[randomIndex];
        Console.WriteLine(prompt);
    }
    private void questions()
    {
        string[] questions = new string[]
        {
            "What did you learn from that experience?",
            "How did you feel during that time?",
            "What challenges did you face?",
            "How did you overcome those challenges?",
            "What strengths did you discover in yourself?"
        };
        Random random = new Random();
        int randomIndex = random.Next(questions.Length);
        string question = questions[randomIndex];
        Console.WriteLine(question);
    }
}