using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write(" Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        int asum = 0;
        foreach (int num in numbers)
        {
            asum += num;
        }
        float average = ((float)asum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}