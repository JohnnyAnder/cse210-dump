using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracker!");
        Menu menu = new Menu();
        string choice = "";
        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
        }
        {
            switch (choice)
            {
                case "1":
                    menu.();
                    break;
                case "2":
                    menu.ListGoals();
                    break;
                case "3":
                    menu.save();
                    break;
                case "4":
                    menu.load();
                    break;
                case "5":
                    menu.DisplayGoals();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}