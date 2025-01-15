using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine().Trim());
        bool isPrime = number > 1;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine($"{number} is a prime number.");
        else
            Console.WriteLine($"{number} is not a prime number.");
    }
}
