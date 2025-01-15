using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of values (k): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k <= 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a positive integer.");
            return;
        }

        Console.Write("Enter number 1: ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double firstNum))
        {
            Console.WriteLine("Invalid input for number 1. Please enter a valid number.");
            return;
        }
        double max = firstNum;
        double min = firstNum;

        for (int i = 2; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            if (!double.TryParse(Console.ReadLine()?.Trim(), out double num))
            {
                Console.WriteLine($"Invalid input for number {i}. Please enter a valid number.");
                return;
            }
            
            if (num > max) max = num;
            if (num < min) min = num;
        }

        Console.WriteLine($"\nLargest number: {max}");
        Console.WriteLine($"Smallest number: {min}");
    }
}
