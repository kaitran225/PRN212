using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select shape: sphere, cylinder, cone, rectangular box");
        string? shape = Console.ReadLine()?.Trim().ToLower();

        switch (shape)
        {
            case "sphere":
                Console.Write("Enter radius: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double radius))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.WriteLine($"Volume: {(4.0 / 3.0) * Math.PI * Math.Pow(radius, 3)}");
                break;

            case "cylinder":
                Console.Write("Enter radius: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double cylRadius))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.Write("Enter height: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double height))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.WriteLine($"Volume: {Math.PI * Math.Pow(cylRadius, 2) * height}");
                break;

            case "cone":
                Console.Write("Enter radius: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double coneRadius))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.Write("Enter height: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double coneHeight))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.WriteLine($"Volume: {(1.0 / 3.0) * Math.PI * Math.Pow(coneRadius, 2) * coneHeight}");
                break;

            case "rectangular box":
                Console.Write("Enter length: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double length))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.Write("Enter width: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double width))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.Write("Enter height: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double boxHeight))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.WriteLine($"Volume: {length * width * boxHeight}");
                break;

            default:
                Console.WriteLine("Invalid shape.");
                break;
        }
    }
}
