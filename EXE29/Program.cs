internal class Program
{
    private static bool read()
    {
        string? filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.csv");

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
