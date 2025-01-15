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

        int positiveOddCount = 0;
        int negativeEvenCount = 0;

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            int num = int.Parse(Console.ReadLine().Trim());
            
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
