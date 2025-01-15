using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine().Trim());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine().Trim());

        Console.WriteLine("Select operation: +, -, *, /");
        char operation = Console.ReadLine().Trim()[0];

        double result = operation switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num1 / num2,
            _ => double.NaN
        };

        if (double.IsNaN(result))
            Console.WriteLine("Invalid operation.");
        else
            Console.WriteLine($"Result: {result}");
    }
}
