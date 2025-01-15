using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine().Trim());

        if (k == 0)
        {
            Console.WriteLine("Error: k cannot be zero");
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