internal class Program
{
    private static bool cal()
    {
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return false;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return false;
        }

        Console.WriteLine("Select operation: +, -, *, /");
        char operation = Console.ReadLine()?.Trim()[0] ?? '\0';

        double result = operation switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : double.NaN,
            _ => double.NaN
        };

        if (double.IsNaN(result))
            Console.WriteLine("Invalid operation or division by zero.");
        else
            Console.WriteLine($"Result: {result}");
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
