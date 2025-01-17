class Program
{
    private static bool reverse()
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        int reversedNumber = ReverseDigits(number);
        Console.WriteLine($"Reversed number: {reversedNumber}");
        return true;
    }

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
    static void Main(string[] args)
    {
        while (true)
        {
            if (reverse())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
