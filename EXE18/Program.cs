using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        string binary = Convert.ToString(number, 2);

        Console.WriteLine($"Binary equivalent: {binary}");
    }
}
