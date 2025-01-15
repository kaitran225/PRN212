using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select shape: square, rectangle, circle, triangle");
        string shape = Console.ReadLine().Trim().ToLower();

        switch (shape)
        {
            case "square":
                Console.Write("Enter side length: ");
                double side = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Area: {side * side}, Perimeter: {4 * side}");
                break;

            case "rectangle":
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine().Trim());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Area: {length * width}, Perimeter: {2 * (length + width)}");
                break;

            case "circle":
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Area: {Math.PI * radius * radius}, Circumference: {2 * Math.PI * radius}");
                break;

            case "triangle":
                Console.Write("Enter base: ");
                double baseLength = double.Parse(Console.ReadLine().Trim());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine($"Area: {0.5 * baseLength * height}");
                break;

            default:
                Console.WriteLine("Invalid shape.");
                break;
        }
    }
}
