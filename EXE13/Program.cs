internal class Program
{
    private static bool palindrome()
    {
        Console.Write("Enter a word: ");
        string? word = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine("Invalid input. Please enter a non-empty word.");
            return false;
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
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (palindrome())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
