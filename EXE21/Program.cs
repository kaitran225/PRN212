internal class Program
{
    private static bool cal()
    {
        Console.WriteLine("Select shape: square, rectangle, circle, triangle");
        string? shape = Console.ReadLine()?.Trim().ToLower();

        switch (shape)
        {
            case "square":
                Console.Write("Enter side length: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double side))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return false;
                }
                Console.WriteLine($"Area: {side * side}, Perimeter: {4 * side}");
                break;

            case "rectangle":
                Console.Write("Enter length: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double length))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return false;
                }
                Console.Write("Enter width: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double width))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return false;
                }
                Console.WriteLine($"Area: {length * width}, Perimeter: {2 * (length + width)}");
                break;

            case "circle":
                Console.Write("Enter radius: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double radius))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return false;
                }
                Console.WriteLine($"Area: {Math.PI * radius * radius}, Circumference: {2 * Math.PI * radius}");
                break;

            case "triangle":
                Console.Write("Enter base: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double baseLength))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return false;
                }
                Console.Write("Enter height: ");
                if (!double.TryParse(Console.ReadLine()?.Trim(), out double height))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return false;
                }
                Console.WriteLine($"Area: {0.5 * baseLength * height}");
                break;

            default:
                Console.WriteLine("Invalid shape.");
                break;
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
