using System;
internal class Program
{
    static void Main(string[] args)
    {
        double balance = 0;
        while (true)
        {
            Console.WriteLine("Select an option: 1) Deposit 2) Withdraw 3) Check Balance 4) Exit");
            if (!int.TryParse(Console.ReadLine()?.Trim(), out int option))
            {
                Console.WriteLine("Invalid option. Please enter a valid integer.");
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    if (!double.TryParse(Console.ReadLine()?.Trim(), out double deposit))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }
                    balance += deposit;
                    Console.WriteLine($"Deposited: {deposit}, New Balance: {balance}");
                    break;

                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    if (!double.TryParse(Console.ReadLine()?.Trim(), out double withdraw))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.WriteLine($"Withdrawn: {withdraw}, New Balance: {balance}");
                    }
                    break;

                case 3:
                    Console.WriteLine($"Current Balance: {balance}");
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
