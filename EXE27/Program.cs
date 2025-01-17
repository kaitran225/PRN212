internal class Program
{
    private static bool read()
    {
        string? filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "text.txt");
        
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
