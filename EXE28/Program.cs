using System;
using System.Collections.Generic;

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

        Dictionary<string, double> studentGrades = new Dictionary<string, double>();

        for (int i = 0; i < k; i++)
        {
            Console.Write($"Enter name for student {i + 1}: ");
            string name = Console.ReadLine().Trim();
            
            Console.Write($"Enter score for {name}: ");
            double score = double.Parse(Console.ReadLine().Trim());
            studentGrades[name] = score;
        }

        Console.Write("Enter threshold score (t): ");
        double threshold = double.Parse(Console.ReadLine().Trim());

        Console.WriteLine("\nStudents who scored above threshold:");
        foreach (var student in studentGrades)
        {
            if (student.Value > threshold)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }

        var topStudent = studentGrades.OrderByDescending(s => s.Value).First();
        Console.WriteLine($"\nTop student: {topStudent.Key} with score: {topStudent.Value}");
    }
}
