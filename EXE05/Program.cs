using System;
internal class EXE01
{
    private static bool PrintDivisibleByK()
    {
        Console.Write("Enter lower bound: ");
        int? n = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter upper bound: ");
        int? m = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter divider k: ");
        int? k = int.Parse(Console.ReadLine().Trim());

        if (n < m || ( k != 0))
        {
            for (int i = (int)n; i <= m; i++)
            {
                if(i % k == 0)
                {
                    Console.WriteLine(i);
                }
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
            if (PrintDivisibleByK())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}