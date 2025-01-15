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

        int positiveOddCount = 0;
        int negativeEvenCount = 0;

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            if (!int.TryParse(Console.ReadLine()?.Trim(), out int num))
            {
                Console.WriteLine($"Invalid input for number {i}. Please enter a valid integer.");
                return;
            }
            
            if (num > 0 && num % 2 != 0)
                positiveOddCount++;
            else if (num < 0 && num % 2 == 0)
                negativeEvenCount++;
        }

        Console.WriteLine("\nResults:");
        Console.WriteLine($"Positive odd numbers: {positiveOddCount}");
        Console.WriteLine($"Negative even numbers: {negativeEvenCount}");
    }
}
