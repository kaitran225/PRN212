internal class Program
{
    private static bool Average()
    {
        Console.Write("Enter the number of values (k): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k <= 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a positive integer.");
            return false;
        }

        double sum = 0;
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
                sum += num;
                break;
            }
        }

        double average = sum / k;
        Console.WriteLine($"\nAverage: {average:F2}");
        return true;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            if (Average())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }

}
