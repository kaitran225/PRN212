using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string? sentence = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            Console.WriteLine("Invalid input. Please enter a non-empty sentence.");
            return;
        }

        int wordCount = sentence.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;

        Console.WriteLine($"Number of words: {wordCount}");
    }
}
