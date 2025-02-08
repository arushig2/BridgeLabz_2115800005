using System;

public class BankAccount
{
    public long accountNumber;
    public double balance;

    public BankAccount(long accountNumber, double balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance);
    }
}

public class SavingsAccount : BankAccount
{
    public double interestRate;

    public SavingsAccount(long accountNumber, double balance, double interestRate) : base(accountNumber, balance)
    {
        this.interestRate = interestRate;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Savings Account Details: ");
        base.DisplayAccountDetails();
        Console.WriteLine("Interest Rate: " + interestRate);
    }
}

public class CheckingAccount : BankAccount
{
    public double withdrawalLimit;

    public CheckingAccount(long accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
    {
        this.withdrawalLimit = withdrawalLimit;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Checking Account Details: ");
        base.DisplayAccountDetails();
        Console.WriteLine("Withdrawal Limit: " + withdrawalLimit);
    }
}

public class FixedDepositAccount : BankAccount
{
    public int duration;

    public FixedDepositAccount(long accountNumber, double balance, int duration) : base(accountNumber, balance)
    {
        this.duration = duration;
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Fixed Deposit Account Details: ");
        base.DisplayAccountDetails();
        Console.WriteLine("Duration: " + duration);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1, 1000);
        account.DisplayAccountDetails();

        Console.WriteLine();

        SavingsAccount savingsAccount = new SavingsAccount(2, 2000, 5);
        savingsAccount.DisplayAccountDetails();

        Console.WriteLine();

        CheckingAccount checkingAccount = new CheckingAccount(3, 3000, 1000);
        checkingAccount.DisplayAccountDetails();

        Console.WriteLine();

        FixedDepositAccount fixedDepositAccount = new FixedDepositAccount(4, 4000, 5);
        fixedDepositAccount.DisplayAccountDetails();
    }
}
