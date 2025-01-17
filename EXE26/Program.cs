internal class Program
{
    private static bool game()
    {
        Random random = new Random();
        Console.Write("Enter lower bound (n): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        Console.Write("Enter upper bound (m): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int m))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return false;
        }

        if (n >= m)
        {
            Console.WriteLine("Lower bound should be less than upper bound.");
            return false;
        }

        int target = random.Next(n, m + 1);
        int guess = 0;

        Console.WriteLine("Guess the number!");

        while (guess != target)
        {
            Console.Write("Enter your guess: ");
            if (!int.TryParse(Console.ReadLine()?.Trim(), out guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            if (guess < target)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > target)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Correct! You guessed the number.");
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        game();
        while (true)
        {
            Console.Write("Enter Y to play again or X to exit: ");
            string? input = Console.ReadLine()?.Trim().ToUpper();
            if (input == "X")
            {
                Console.WriteLine("Thank you for playing! Press any key to exit...");
                Console.ReadLine();
                break;
            }
            else if (input != "Y")
            {
                Console.WriteLine("Invalid input. Please enter X or Y.");
                continue;
            }
            game();
        }
    }
}
