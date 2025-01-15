using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input for n. Please enter an integer.");
            return;
        }
        
        Console.Write("Enter m: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int m))
        {
            Console.WriteLine("Invalid input for m. Please enter an integer.");
            return;
        }

        if (n < m)
        {
            Console.WriteLine($"\nEven numbers from {m} to {n} in reverse order:");
            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Error: n should be less than m");
        }
    }
}