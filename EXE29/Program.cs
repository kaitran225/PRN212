internal class Program
{
    private static bool read()
    {
        Console.Write("Enter the path to the .csv file: ");
        Console.WriteLine("Sample file:  ..\\PRN212\\EXE29\\products.csv");
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
        if (!filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Please enter a valid .csv file path.");
            return false;
        }
        double totalValue = 0;
        Console.WriteLine($"Products priced above a certain amount:");

        Console.Write("Enter price threshold (p): ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double priceThreshold))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return false;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 3)
            {
                string productName = parts[0].Trim();
                if (!double.TryParse(parts[1].Trim(), out double price))
                {
                    Console.WriteLine($"Invalid price for product: {productName}. Skipping...");
                    continue;
                }
                if (!int.TryParse(parts[2].Trim(), out int quantity))
                {
                    Console.WriteLine($"Invalid quantity for product: {productName}. Skipping...");
                    continue;
                }

                if (price > priceThreshold)
                {
                    Console.WriteLine($"{productName} - Price: {price}, Quantity: {quantity}");
                    totalValue += price * quantity;
                }
            }
        }

        Console.WriteLine($"Total inventory value: {totalValue}");
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
