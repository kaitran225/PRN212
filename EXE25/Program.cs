using System;
internal class Program
{
    static void Main(string[] args)
    {
        double balance = 0;
        while (true)
        {
            Console.WriteLine("Select an option: 1) Deposit 2) Withdraw 3) Check Balance 4) Exit");
            int option = int.Parse(Console.ReadLine().Trim());

            switch (option)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine().Trim());
                    balance += deposit;
                    Console.WriteLine($"Deposited: {deposit}, New Balance: {balance}");
                    break;

                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine().Trim());
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
