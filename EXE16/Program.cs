internal class Program
{
    private static bool factorial()
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return false;
        }

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {n} is: {factorial}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (factorial())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
