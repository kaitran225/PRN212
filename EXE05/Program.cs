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
        
        Console.Write("Enter k: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k == 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a non-zero integer.");
            return;
        }

        int sum = 0;
        Console.WriteLine($"\nNumbers between {n} and {m} divisible by {k}:");
        
        for (int i = n; i <= m; i++)
        {
            if (i % k == 0)
            {
                Console.Write($"{i} ");
                sum += i;
            }
        }
        Console.WriteLine($"\nSum of numbers divisible by {k}: {sum}");
    }
}