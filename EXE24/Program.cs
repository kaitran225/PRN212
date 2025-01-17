internal class Program
{
    private static bool cal()
    {
        Console.WriteLine("Enter numbers (enter -1 to stop):");
        double sum = 0;
        double count = 0;
        double max = double.MinValue;
        double min = double.MaxValue;

        while (true)
        {
            if (!double.TryParse(Console.ReadLine()?.Trim(), out double num))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (num == -1) break;

            sum += num;
            count++;
            if (num > max) max = num;
            if (num < min) min = num;
        }

        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"Average: {average:F2}, Max: {max}, Min: {min}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");

        }
        return true;
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
