using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the position of Fibonacci number (n): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        if (n < 0)
        {
            Console.WriteLine("Error: n must be non-negative");
            return;
        }

        Console.WriteLine($"Fibonacci number at position {n}: {Fibonacci(n)}");
    }

    static long Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("n must be non-negative.");
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
