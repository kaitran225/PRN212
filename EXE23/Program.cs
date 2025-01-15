using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter lower bound (n): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }
        
        Console.Write("Enter upper bound (m): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int m))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        if (n > m)
        {
            Console.WriteLine("Lower bound should not be greater than upper bound.");
            return;
        }

        Console.WriteLine($"\nPrime numbers between {n} and {m}:");
        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
