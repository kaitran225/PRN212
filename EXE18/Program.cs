internal class Program
{
    private static bool convert()
    {
        Console.Write("Enter a decimal number: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        string binary = Convert.ToString(number, 2);

        Console.WriteLine($"Binary equivalent: {binary}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (convert())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
