using System;

internal class Program
{
    private static void Main()
    {
        Console.Write("Enter the number of disks: ");
        if (!int.TryParse(Console.ReadLine()?.Trim(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        if (n <= 0)
        {
            Console.WriteLine("Number of disks must be positive.");
            return;
        }

        Console.WriteLine("The sequence of moves involved in the Tower of Hanoi are:");
        TowerOfHanoi(n, 'A', 'C', 'B');
    }

    private static void TowerOfHanoi(int n, char source, char target, char auxiliary)
    {
        if (n < 1) throw new ArgumentException("Number of disks must be positive.");
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {target}");
            return;
        }
        TowerOfHanoi(n - 1, source, auxiliary, target);
        Console.WriteLine($"Move disk {n} from {source} to {target}");
        TowerOfHanoi(n - 1, auxiliary, target, source);
    }
}
