using System;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("Enter lower bound (n): ");
        int n = int.Parse(Console.ReadLine().Trim());
        
        Console.Write("Enter upper bound (m): ");
        int m = int.Parse(Console.ReadLine().Trim());
        
        int target = random.Next(n, m + 1);
        int guess = 0;

        Console.WriteLine("Guess the number!");

        while (guess != target)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine().Trim());

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
