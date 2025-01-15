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
        
        Console.Write("Enter x: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int x) || x == 0)
        {
            Console.WriteLine("Invalid input for x. Please enter a non-zero integer.");
            return;
        }
        
        Console.Write("Enter y: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int y) || y == 0)
        {
            Console.WriteLine("Invalid input for y. Please enter a non-zero integer.");
            return;
        }

        int count = 0;
        Console.WriteLine($"\nNumbers divisible by both {x} and {y}:");
        
        for (int i = n; i <= m; i++)
        {
            if (i % x == 0 && i % y == 0)
            {
                Console.Write($"{i} ");
                count++;
            }
        }
        Console.WriteLine($"\nCount: {count}");
    }
}