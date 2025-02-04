using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // The working journal instance to store user entries
    public static Journal workingJournal = new Journal();

    static void Main(string[] args)
    {
        MenuLoop();
    }

    // Displays the menu and handles user choices.
    static void MenuLoop()
    {
        int key = 0;
        while (key != 1)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("Your choice: ");

            // Validates user input
            if (!int.TryParse(Console.ReadLine(), out int response))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            // Executes actions based on user selection
            switch (response)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    workingJournal.Display();
                    break;
                case 3:
                    LoadJournalFile();
                    break;
                case 4:
                    SaveJournalFile();
                    break;
                case 5:
                    Console.WriteLine("Have a nice day!");
                    key = 1;
                    break;
                default:
                    Console.WriteLine("That is not an option. Please pick an option 1-5.");
                    break;
            }
        }
    }

    // Generates a new journal entry using a random prompt.
    static void WriteNewEntry()
    {
        Prompt promptGenerator = new Prompt();
        string prompt = promptGenerator.GeneratePrompt();
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("Your entry: ");
        string entryText = Console.ReadLine();

        // Create a new entry and add it to the journal
        Entry newEntry = new Entry(prompt, entryText);
        workingJournal.AppendEntry(newEntry);
    }

    // Saves the current journal entries to a file.
    static void SaveJournalFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();
        workingJournal.SaveToFile(filename);
    }

    // Loads journal entries from a file.
    static void LoadJournalFile()
    {
        Console.Write("Enter a filename to load a journal: ");
        string filename = Console.ReadLine();
        workingJournal.LoadFromFile(filename);
    }
}
