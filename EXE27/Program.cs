internal class Program
{
    private static bool read()
    {
        Console.Write("Enter the path to the text file: ");
        Console.WriteLine("Sample file:  ..\\PRN212\\EXE27\\text.txt");
        string? filePath = Console.ReadLine()?.Trim();
        

        if (string.IsNullOrEmpty(filePath))
        {
            Console.WriteLine("File path cannot be empty. Please enter a valid path.");
            return false;
        }
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist. Please ensure the file exists.");
            return false;
        }
        if (!filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Please enter a valid .txt file path.");
            return false;
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
        return true;
    }
    static void Main(string[] args)
    {
        while (true)
        {
            if (read())
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
                break;
            }
        }
    }
}
