using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {n} is: {factorial}");
    }
}
