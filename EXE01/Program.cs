internal class EXE01
{
    private static bool PrintRangedNums()
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

        if (n < m)
        {
            for (int i = n; i <= m; i++)
            {
                Console.WriteLine(i);
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
            if (PrintRangedNums())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}