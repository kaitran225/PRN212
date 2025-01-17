        using System;
internal class EXE02
{
    private static bool PrintDivisibleByK()
    {
        Console.Write("Enter lower bound: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input for lower bound. Please enter an integer.");
            return false;
        }

        Console.Write("Enter upper bound: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int m))
        {
            Console.WriteLine("Invalid input for upper bound. Please enter an integer.");
            return false;
        }

        Console.Write("Enter divider k: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k == 0)
        {
            Console.WriteLine("Invalid input for divider k. Please enter a non-zero integer.");
            return false;
        }

        if (n < m)
        {
            for (int i = n; i <= m; i++)
            {
                if (i % k == 0)
                {
                    Console.WriteLine(i);
                }
            }
            return true;
        }
        else
        {
            Console.WriteLine("Lower bound should not be either equal to or larger than upper bound.");
            return false;
        }
    }

    private static void Main(string[] args)
    {
        while (true)
        {
            if (PrintDivisibleByK())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}