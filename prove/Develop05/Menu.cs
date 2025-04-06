public class Menu
{
    private List<Goal> _goals = new List<Goal>();
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Display Goals");
        Console.WriteLine("6. Quit");
    }
    public void save()
    {
        Console.WriteLine("Enter the filename to save the goals: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{Goal._goal}:{Goal._description}|{Goal._points}");
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
    public void load()
    {
        Console.WriteLine("Enter the filename to load the goals: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string goal = parts[0];
                    string[] details = parts[1].Split('|');
                    string description = details[0];
                    int points = int.Parse(details[1]);
                    Goal newGoal = new Goal(goal, description, points);
                    _goals.Add(newGoal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            
        }
    }
}