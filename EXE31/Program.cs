internal class Program
{
    private static bool gcdCal()
    {
        Console.Write("Enter first number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int a))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        Console.Write("Enter second number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int b))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        Console.WriteLine($"GCD of {a} and {b} is: {GCD(a, b)}");
        return true;
    }

    private static int GCD(int a, int b)
    {
        if (a < 0 || b < 0) throw new ArgumentException("Both numbers must be non-negative.");
        if (b == 0) return a;
        return GCD(b, a % b);
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (gcdCal())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
