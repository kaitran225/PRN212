internal class Program
{
    private static int ReverseDigits(int num)
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

    private static bool what()
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        int smallestDigit = 9, largestDigit = 0, sum = 0;
        int reversedNumber = ReverseDigits(number);

        while (number > 0)
        {
            int digit = number % 10;
            if (digit < smallestDigit) smallestDigit = digit;
            if (digit > largestDigit) largestDigit = digit;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine($"Reversed number: {reversedNumber}");
        Console.WriteLine($"Smallest digit: {smallestDigit}");
        Console.WriteLine($"Largest digit: {largestDigit}");
        Console.WriteLine($"Sum of digits: {sum}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (what())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
