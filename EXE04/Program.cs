using System;
internal class EXE04
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

        int sum = 0;
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }

        Console.WriteLine($"\nSum of all numbers from {n} to {m}: {sum}");
    }
}