using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of values (k): ");
        int k = int.Parse(Console.ReadLine().Trim());

        if (k <= 0)
        {
            Console.WriteLine("Error: k must be positive");
            return;
        }

        Console.Write("Enter number 1: ");
        double firstNum = double.Parse(Console.ReadLine().Trim());
        double max = firstNum;
        double min = firstNum;

        for (int i = 2; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            double num = double.Parse(Console.ReadLine().Trim());
            
            if (num > max) max = num;
            if (num < min) min = num;
        }

        Console.WriteLine($"\nLargest number: {max}");
        Console.WriteLine($"Smallest number: {min}");
    }
}
