using System;

public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }  
    }

    public double Balance
    {
        get { return balance; }         
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be zero or negative!");
            }
        }
    }

    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        Balance = initialBalance;   
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Successfully deposited {amount}. New Balance = {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Successfully withdrawal {amount}. New Balance = {balance}");
    }
}
