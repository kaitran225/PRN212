internal class Program
{
    private static bool countVow()
    {
        Console.WriteLine("Enter a sentence:");
        string? sentence = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            Console.WriteLine("Invalid input. Please enter a non-empty sentence.");
            return false;
        }

        int vowelCount = 0;
        int spaceCount = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in sentence)
        {
            if (vowels.Contains(c))
                vowelCount++;
            if (c == ' ')
                spaceCount++;
        }

        Console.WriteLine("\nResults:");
        Console.WriteLine($"Number of vowels: {vowelCount}");
        Console.WriteLine($"Number of spaces: {spaceCount}");
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (countVow())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
