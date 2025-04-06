public class Goal
{
   private string _goal;
   private string _description;
   private int _points;
   private int _times;
   private int _bonus;
   public Goal(string goal, string description, int points, int times, int bonus)
   {
       _goal = goal;
       _description = description;
       _points = points;
       _times = times;
       _bonus = bonus;
   }
   public void DisplayGoalType()
   {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
   }
   public void CreateGoal()
   {
        Console.Clear();
        Console.WriteLine("Which type of goal would you like to create?");
        DisplayGoalType();
        string goalType = Console.ReadLine();
        switch (goalType)
        {
            //1. Simple Goal
            case "1":
                Console.WriteLine("Enter the goal: ");
                _goal = Console.ReadLine();
                Console.WriteLine("Enter the description: ");
                _description = Console.ReadLine();
                Console.WriteLine("Enter the points: ");
                _points = int.Parse(Console.ReadLine());
                _times = 1;
                _bonus = 0;
                new Goal(_goal, _description, _points, _times, _bonus);
                Console.WriteLine("Goal created successfully.");
                break;
            //2. Eternal Goal
            case "2":
                Console.WriteLine("Enter the goal: ");
                _goal = Console.ReadLine();
                Console.WriteLine("Enter the description: ");
                _description = Console.ReadLine();
                Console.WriteLine("Enter the points: ");
                _points = int.Parse(Console.ReadLine());
                _times = 0;
                _bonus = 0;
                new Goal(_goal, _description, _points, _times, _bonus);
                Console.WriteLine("Goal created successfully.");
                break;
            //3. Checklist Goal
            case "3":
                Console.WriteLine("Enter the goal: ");
                _goal = Console.ReadLine();
                Console.WriteLine("Enter the description: ");
                _description = Console.ReadLine();
                Console.WriteLine("Enter the number of times the goal must be completed: ");
                _times = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of points for each time the goal is completed: ");
                _points = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points for completing the goal: ");
                _bonus = int.Parse(Console.ReadLine());
                new Goal(_goal, _description, _points, _times, _bonus);
                Console.WriteLine("Goal created successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
   }
}