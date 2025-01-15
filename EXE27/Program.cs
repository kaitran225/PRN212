using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the file path: ");
        string? filePath = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(filePath))
        {
            Console.WriteLine("Invalid file path. Please enter a non-empty path.");
            return;
        }

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);
        int wordCount = 0;
        int charCount = 0;
        string longestWord = "";

        foreach (string line in lines)
        {
            charCount += line.Length;
            string[] words = line.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount += words.Length;

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
        }

        Console.WriteLine($"Lines: {lines.Length}, Words: {wordCount}, Characters: {charCount}");
        Console.WriteLine($"Longest word: {longestWord}");
    }
}
