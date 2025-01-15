using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the CSV file path: ");
        string filePath = Console.ReadLine().Trim();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        double totalValue = 0;
        Console.WriteLine($"Products priced above a certain amount:");

        Console.Write("Enter price threshold (p): ");
        double priceThreshold = double.Parse(Console.ReadLine().Trim());

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 3)
            {
                string productName = parts[0].Trim();
                double price = double.Parse(parts[1].Trim());
                int quantity = int.Parse(parts[2].Trim());

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
