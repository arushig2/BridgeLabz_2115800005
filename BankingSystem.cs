using System;
using System.Collections.Generic;
using System.Linq;

class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>(); 
    private SortedDictionary<double, List<int>> sortedAccounts = new SortedDictionary<double, List<int>>(); 
    private Queue<(int, double)> withdrawalQueue = new Queue<(int, double)>(); 

    public void AddAccount(int accountNumber, double initialBalance)
    {
        if (!accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] = initialBalance;
            UpdateSortedAccounts(accountNumber, initialBalance);
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} already exists!");
        }
    }

    private void UpdateSortedAccounts(int accountNumber, double balance)
    {
        if (!sortedAccounts.ContainsKey(balance))
        {
            sortedAccounts[balance] = new List<int>();
        }
        sortedAccounts[balance].Add(accountNumber);
    }

    public void Deposit(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            double oldBalance = accountBalances[accountNumber];
            accountBalances[accountNumber] += amount;

            sortedAccounts[oldBalance].Remove(accountNumber);
            if (sortedAccounts[oldBalance].Count == 0) sortedAccounts.Remove(oldBalance);
            UpdateSortedAccounts(accountNumber, accountBalances[accountNumber]);

            Console.WriteLine($"Deposited ${amount} into Account {accountNumber}. New Balance: ${accountBalances[accountNumber]}");
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} not found.");
        }
    }

    public void RequestWithdrawal(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            withdrawalQueue.Enqueue((accountNumber, amount));
            Console.WriteLine($"Withdrawal request of ${amount} from Account {accountNumber} added to queue.");
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} not found.");
        }
    }

    public void ProcessWithdrawals()
    {
        Console.WriteLine("\nProcessing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            var (accountNumber, amount) = withdrawalQueue.Dequeue();
            if (accountBalances[accountNumber] >= amount)
            {
                double oldBalance = accountBalances[accountNumber];
                accountBalances[accountNumber] -= amount;

                sortedAccounts[oldBalance].Remove(accountNumber);
                if (sortedAccounts[oldBalance].Count == 0) sortedAccounts.Remove(oldBalance);
                UpdateSortedAccounts(accountNumber, accountBalances[accountNumber]);

                Console.WriteLine($"Withdrawal of ${amount} from Account {accountNumber} successful. New Balance: ${accountBalances[accountNumber]}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in Account {accountNumber} for withdrawal of ${amount}.");
            }
        }
    }

    public void DisplayAccounts()
    {
        Console.WriteLine("\nAccount Balances:");
        foreach (var kvp in accountBalances)
        {
            Console.WriteLine($"Account {kvp.Key}: ${kvp.Value}");
        }
    }

    public void DisplaySortedAccounts()
    {
        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var kvp in sortedAccounts)
        {
            foreach (var account in kvp.Value)
            {
                Console.WriteLine($"Account {account}: ${kvp.Key}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();

        bank.AddAccount(101, 500.00);
        bank.AddAccount(102, 1500.00);
        bank.AddAccount(103, 700.00);

        bank.Deposit(101, 300.00);
        bank.Deposit(103, 200.00);

        bank.RequestWithdrawal(102, 500.00);
        bank.RequestWithdrawal(103, 1000.00); 

        bank.DisplayAccounts();
        bank.DisplaySortedAccounts();

        bank.ProcessWithdrawals();

        bank.DisplayAccounts();
        bank.DisplaySortedAccounts();
    }
}
