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

        int positiveCount = 0, negativeCount = 0;
        int evenCount = 0, oddCount = 0;
        double positiveSum = 0, negativeSum = 0;

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            if (!double.TryParse(Console.ReadLine()?.Trim(), out double num))
            {
                Console.WriteLine($"Invalid input for number {i}. Please enter a valid number.");
                return;
            }
            
            if (num > 0)
            {
                positiveSum += num;
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeSum += num;
                negativeCount++;
            }

            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("\nResults:");
        if (positiveCount > 0)
            Console.WriteLine($"Average of positive numbers: {positiveSum/positiveCount:F2}");
        if (negativeCount > 0)
            Console.WriteLine($"Average of negative numbers: {negativeSum/negativeCount:F2}");
        Console.WriteLine($"Even numbers count: {evenCount}");
        Console.WriteLine($"Odd numbers count: {oddCount}");
    }
}
