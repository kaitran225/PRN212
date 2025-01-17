internal class Program
{
    private static bool dictionary()
    {
        Console.Write("Enter number of students (k): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int k) || k <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return false;
        }

        Dictionary<string, double> studentGrades = new Dictionary<string, double>();

        for (int i = 0; i < k; i++)
        {
            Console.Write($"Enter name for student {i + 1}: ");
            string? name = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input. Please enter a non-empty name.");
                i--;
                continue;
            }

            Console.Write($"Enter score for {name}: ");
            if (!double.TryParse(Console.ReadLine()?.Trim(), out double score))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
                continue;
            }

            studentGrades[name] = score;
        }

        Console.Write("Enter threshold score (t): ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double threshold))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return false;
        }

        Console.WriteLine("\nStudents who scored above threshold:");
        foreach (var student in studentGrades)
        {
            if (student.Value > threshold)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }

        if (studentGrades.Count > 0)
        {
            var topStudent = studentGrades.OrderByDescending(s => s.Value).First();
            Console.WriteLine($"\nTop student: {topStudent.Key} with score: {topStudent.Value}");
        }
        else
        {
            Console.WriteLine("No students were entered.");

        }
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (dictionary())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
