using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers (enter -1 to stop):");
        double sum = 0;
        double count = 0;
        double max = double.MinValue;
        double min = double.MaxValue;

        while (true)
        {
            double num = double.Parse(Console.ReadLine().Trim());
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
    }
}
