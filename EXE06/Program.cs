internal class Program
{
    private static bool DivisibleByXY()
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

        Console.Write("Enter x: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int x) || x == 0)
        {
            Console.WriteLine("Invalid input for x. Please enter a non-zero integer.");
            return false;
        }

        Console.Write("Enter y: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int y) || y == 0)
        {
            Console.WriteLine("Invalid input for y. Please enter a non-zero integer.");
            return false;
        }

        if (n >= m)
        {
            Console.WriteLine("Lower bound should not be either equal to or larger than upper bound.");
            return false;
        }
        if (x == y)
        {
            Console.WriteLine("X and Y varible should be different.");
            return false;
        }
        int count = 0;
        Console.WriteLine($"\nNumbers divisible by both {x} and {y}:");

        for (int i = n; i <= m; i++)
        {
            if (i % x == 0 && i % y == 0)
            {
                Console.Write($"{i} ");
                count++;
            }
        }
        Console.WriteLine($"\nCount: {count}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (DivisibleByXY())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}