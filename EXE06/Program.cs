using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine().Trim());

        if (x == 0 || y == 0)
        {
            Console.WriteLine("Error: x and y cannot be zero");
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