using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
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
    }
}
