using System;
internal class EXE01
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }

        Console.WriteLine($"\nSum of all numbers from {n} to {m}: {sum}");
    }
}