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

        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            double num = double.Parse(Console.ReadLine().Trim());
            sum += num;
        }

        double average = sum / k;
        Console.WriteLine($"\nAverage: {average:F2}");
    }
}
