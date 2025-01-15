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

        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            if (!double.TryParse(Console.ReadLine()?.Trim(), out double num))
            {
                Console.WriteLine($"Invalid input for number {i}. Please enter a valid number.");
                return;
            }
            sum += num;
        }

        double average = sum / k;
        Console.WriteLine($"\nAverage: {average:F2}");
    }
}
