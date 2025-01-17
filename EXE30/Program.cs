internal class Program
{
    private static bool cal()
    {
        Console.Write("Enter the position of Fibonacci number (n): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        if (n < 0)
        {
            Console.WriteLine("Error: n must be non-negative");
            return false;
        }

        Console.WriteLine($"Fibonacci number at position {n}: {Fibonacci(n)}");
        return true;
    }

    private static long Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("n must be non-negative.");
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (cal())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
