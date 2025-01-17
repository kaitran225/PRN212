internal class Program
{
    private static bool SmallLarge()
    {
        Console.Write("Enter the number of values (k): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k <= 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a positive integer.");
            return false;
        }

        Console.Write("Enter number 1: ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double firstNum))
        {
            Console.WriteLine("Invalid input for number 1. Please enter a valid number.");
            return false;
        }
        double max = firstNum;
        double min = firstNum;

        for (int i = 2; i <= k; i++)
        {
            Console.Write($"Enter number {i}: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double num))
                {
                    Console.WriteLine($"Invalid input for number {i}. Please enter a valid number.");
                    continue;
                }
                if (num > max) max = num;
                if (num < min) min = num;
                break;
            }

        }
        Console.WriteLine($"\nLargest number: {max}");
        Console.WriteLine($"Smallest number: {min}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (SmallLarge())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
