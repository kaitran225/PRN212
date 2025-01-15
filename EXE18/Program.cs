using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine().Trim());
        string binary = Convert.ToString(number, 2);

        Console.WriteLine($"Binary equivalent: {binary}");
    }
}
