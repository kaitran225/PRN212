using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        int reversedNumber = ReverseDigits(number);
        Console.WriteLine($"Reversed number: {reversedNumber}");
    }

    static int ReverseDigits(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        return reversed;
    }
}
