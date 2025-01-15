using System;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("Enter lower bound (n): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }
        
        Console.Write("Enter upper bound (m): ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int m))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        if (n >= m)
        {
            Console.WriteLine("Lower bound should be less than upper bound.");
            return;
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
    }
}
