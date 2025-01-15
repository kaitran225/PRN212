using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string? word = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine("Invalid input. Please enter a non-empty word.");
            return;
        }

        string reversedWord = new string(word.Reverse().ToArray());

        if (word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{word} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{word} is not a palindrome.");
        }
    }
}
