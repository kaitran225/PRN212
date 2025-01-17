internal class EXE05
{
    private static bool DivisibleByK()
    {
        Console.Write("Enter n: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input for n. Please enter an integer.");
            return false;
        }

        Console.Write("Enter m: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int m))
        {
            Console.WriteLine("Invalid input for m. Please enter an integer.");
            return false;
        }

        Console.Write("Enter k: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k == 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a non-zero integer.");
            return false;
        }

        int sum = 0;
        Console.WriteLine($"\nNumbers between {n} and {m} divisible by {k}:");
        if (n >= m)
        {
            Console.WriteLine("Lower bound should not be either equal to or larger than upper bound.");
            return false;
        }
        else
        {
            for (int i = n; i <= m; i++)
            {
                if (i % k == 0)
                {
                    Console.Write($"{i} ");
                    sum += i;
                }
            }
            Console.WriteLine($"\nSum of numbers divisible by {k}: {sum}");
            return true;
        }
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (DivisibleByK())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}