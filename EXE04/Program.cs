using System;
internal class EXE01
{




    private static int SumRange(int a, int b)
    {
        int res = 0;
        for (int i = a; i <= b; i++)
        {
            res += i;
        } 
        return res;
    }
    private static void Main(string[] args)
    {
        Console.Write("Enter lower bound: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter upper bound: ");
        int m = int.Parse(Console.ReadLine());
        if (n < m)
        {
            int result = SumRange(n, m);
            Console.WriteLine("Sum of all integers from " + n + " to " + m + " is: " + result);
        }
        else
        {
            Console.WriteLine(" Lower bound should not be either equal nor larger than upper bound");
        }
        Console.WriteLine("Enter any key to exit...");
        Console.ReadKey();
    }
}