using System;
internal class EXE01
{
    private static bool PrintRangedNums()
    {
        Console.Write("Enter lower bound: ");
        int? n = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter upper bound: ");
        int? m = int.Parse(Console.ReadLine().Trim());
        if (n < m)
        {
            for (int i = (int)n; i <= m; i++)
            {
                Console.WriteLine(i);
            }
            return true;
        }
        else
        {
            Console.WriteLine(" Lower bound should not be either equal nor larger than upper bound");
            return false;
        }
    }
    private static void Main(string[] args)
    {

        while (true)
        {
            if (PrintRangedNums()) {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break; }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nNumbers from {n} to {m}:");
        for (int i = n; i <= m; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}