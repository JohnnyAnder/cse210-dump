using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUsername();
        int number = PromptUserNumber();

        int squarenumber = SquareNumber(number);

        DisplayResults(name, squarenumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUsername()
    {
        Console.Write("Please enter your name:  ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:  ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int squarenumber = number * number;

        return squarenumber;
    }
    static void DisplayResults(string name, int squarenumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squarenumber}");
    }
}