using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine().Trim());

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