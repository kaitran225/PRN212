using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the CSV file path: ");
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

        double totalValue = 0;
        Console.WriteLine($"Products priced above a certain amount:");

        Console.Write("Enter price threshold (p): ");
        if (!double.TryParse(Console.ReadLine()?.Trim(), out double priceThreshold))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
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
    }
}
