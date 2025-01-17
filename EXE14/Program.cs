internal class Program
{
    private static bool countWords()
    {
        Console.Write("Enter a sentence: ");
        string? sentence = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            Console.WriteLine("Invalid input. Please enter a non-empty sentence.");
            return false;
        }

        int wordCount = sentence.Split(' ', '\t', '\n').Length;

        Console.WriteLine($"Number of words: {wordCount}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (countWords())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
