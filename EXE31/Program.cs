using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int a))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int b))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        Console.WriteLine($"GCD of {a} and {b} is: {GCD(a, b)}");
        Console.ReadKey();
    }

    static int GCD(int a, int b)
    {
        if (a < 0 || b < 0) throw new ArgumentException("Both numbers must be non-negative.");
        if (b == 0) return a;
        return GCD(b, a % b);
    }
}
