internal class Program
{
    private static bool pass()
    {
        Console.Write("Enter number of students (k): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k <= 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a positive integer.");
            return false;
        }

        Console.Write("Enter passing score (p): ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double passingScore))
        {
            Console.WriteLine("Invalid input for passing score. Please enter a valid number.");
            return false;
        }

        string[] names = new string[k];
        double[] scores = new double[k];
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
            Console.Write($"\nEnter name for student {i + 1}: ");
            names[i] = Console.ReadLine()?.Trim() ?? string.Empty;

            Console.Write($"Enter score for {names[i]}: ");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine()?.Trim(), out scores[i]))
                {
                    Console.WriteLine($"Invalid input for score. Please enter a valid number.");
                    continue;
                }
                sum += scores[i]
                    ; break;
            }

        }

        Console.WriteLine("\nStudents who passed:");
        for (int i = 0; i < k; i++)
        {
            if (scores[i] >= passingScore)
            {
                Console.WriteLine($"{names[i]} - {scores[i]}");
            }
        }

        double average = sum / k;
        Console.WriteLine($"\nClass average: {average:F2}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (pass())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
