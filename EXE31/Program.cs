using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine().Trim());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine($"GCD of {a} and {b} is: {GCD(a, b)}");
    }

    static int GCD(int a, int b)
    {
        if (b == 0) return a;
        return GCD(b, a % b);
    }
}
