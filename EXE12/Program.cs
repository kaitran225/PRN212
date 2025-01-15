using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students (k): ");
        int k = int.Parse(Console.ReadLine().Trim());

        if (k <= 0)
        {
            Console.WriteLine("Error: Number of students must be positive");
            return;
        }

        Console.Write("Enter passing score (p): ");
        double passingScore = double.Parse(Console.ReadLine().Trim());

        string[] names = new string[k];
        double[] scores = new double[k];
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
            Console.Write($"\nEnter name for student {i + 1}: ");
            names[i] = Console.ReadLine().Trim();
            
            Console.Write($"Enter score for {names[i]}: ");
            scores[i] = double.Parse(Console.ReadLine().Trim());
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
