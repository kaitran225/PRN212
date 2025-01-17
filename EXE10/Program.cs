internal class Program
{
    private static bool count()
    {
        Console.Write("Enter the number of values (k): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k <= 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a positive integer.");
            return false;
        }

        int positiveOddCount = 0;
        int negativeEvenCount = 0;

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double num))
                {
                    Console.WriteLine($"Invalid input for number {i}. Please enter a valid number.");
                    continue;
                }

                if (num > 0 && num % 2 != 0)
                    positiveOddCount++;
                else if (num < 0 && num % 2 == 0)
                    negativeEvenCount++;
                break;
            }
        }

        Console.WriteLine("\nResults:");
        Console.WriteLine($"Positive odd numbers: {positiveOddCount}");
        Console.WriteLine($"Negative even numbers: {negativeEvenCount}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (count())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
