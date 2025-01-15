using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students (k): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k <= 0)
        {
            Console.WriteLine("Invalid input for k. Please enter a positive integer.");
            return;
        }

        Console.Write("Enter passing score (p): ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double passingScore))
        {
            Console.WriteLine("Invalid input for passing score. Please enter a valid number.");
            return;
        }

        string[] names = new string[k];
        double[] scores = new double[k];
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
            Console.Write($"\nEnter name for student {i + 1}: ");
            names[i] = Console.ReadLine()?.Trim() ?? string.Empty;
            
            Console.Write($"Enter score for {names[i]}: ");
            if (!double.TryParse(Console.ReadLine()?.Trim(), out scores[i]))
            {
                Console.WriteLine($"Invalid input for score. Please enter a valid number.");
                return;
            }
            sum += scores[i];
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
    }
}
