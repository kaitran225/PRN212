internal class Program
{
    private static bool primeBetween()
    {
        Console.Write("Enter lower bound (n): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        Console.Write("Enter upper bound (m): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int m))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        if (n > m)
        {
            Console.WriteLine("Lower bound should not be greater than upper bound.");
            return false;
        }

        Console.WriteLine($"\nPrime numbers between {n} and {m}:");
        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
            }
        }
        return true;
    }

    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (primeBetween())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
