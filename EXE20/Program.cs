using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine().Trim());
        int smallestDigit = 9, largestDigit = 0, sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit < smallestDigit) smallestDigit = digit;
            if (digit > largestDigit) largestDigit = digit;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine($"Smallest digit: {smallestDigit}");
        Console.WriteLine($"Largest digit: {largestDigit}");
        Console.WriteLine($"Sum of digits: {sum}");
    }
}
