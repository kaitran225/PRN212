using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of disks: ");
        int n = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine("The sequence of moves involved in the Tower of Hanoi are:");
        TowerOfHanoi(n, 'A', 'C', 'B');
    }

    static void TowerOfHanoi(int n, char source, char target, char auxiliary)
    {
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
