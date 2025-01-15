using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select shape: sphere, cylinder, cone, rectangular box");
        string shape = Console.ReadLine().Trim().ToLower();

        switch (shape)
        {
            case "sphere":
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Volume: {(4.0 / 3.0) * Math.PI * Math.Pow(radius, 3)}");
                break;

            case "cylinder":
                Console.Write("Enter radius: ");
                double cylRadius = double.Parse(Console.ReadLine().Trim());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Volume: {Math.PI * Math.Pow(cylRadius, 2) * height}");
                break;

            case "cone":
                Console.Write("Enter radius: ");
                double coneRadius = double.Parse(Console.ReadLine().Trim());
                Console.Write("Enter height: ");
                double coneHeight = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Volume: {(1.0 / 3.0) * Math.PI * Math.Pow(coneRadius, 2) * coneHeight}");
                break;

            case "rectangular box":
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine().Trim());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine().Trim());
                Console.Write("Enter height: ");
                double boxHeight = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Volume: {length * width * boxHeight}");
                break;

            default:
                Console.WriteLine("Invalid shape.");
                break;
        }
    }
}
