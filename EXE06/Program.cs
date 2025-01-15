using System;
internal class EXE01
{
    private static bool PrintDivisibleByK()
    {
        Console.Write("Enter lower bound: ");
        int? n = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter upper bound: ");
        int? m = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter divider x: ");
        int? x = int.Parse(Console.ReadLine().Trim());
        Console.Write("Enter divider y: ");
        int? y = int.Parse(Console.ReadLine().Trim());
        if( x == 0 ||  y == 0)
        {
            Console.WriteLine("Dividers should not equal to zero");
            return false;
        }
        if (x == y) {
            Console.WriteLine("Divider x and y should not be the same");
            return false; }

        if (n < m )
        {
            for (int i = (int)n; i <= m; i++)
            {
                if (i % x == 0 && i % y == 0) 
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