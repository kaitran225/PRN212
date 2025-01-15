using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter lower bound (n): ");
        int n = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter upper bound (m): ");
        int m = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine($"\nPrime numbers between {n} and {m}:");
        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
