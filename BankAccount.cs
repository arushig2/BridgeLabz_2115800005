using System;
using System.Diagnostics.Eventing.Reader;

public interface ILoanable
{
    public void ApplyForLoan();
    public bool CalculateLoanEligibility();
}

public abstract class BankAccount : ILoanable
{
    private int accountNumber;
    private string accountHolder;
    private double balance;

    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public abstract void CalculateInterest();


    public void ApplyForLoan()
    {
        Console.WriteLine("Loan applied successfully");

        if (CalculateLoanEligibility())
        {
            Console.WriteLine("Loan approved");
        }
        else
        {
            Console.WriteLine("Loan rejected");
        }
    }

    public bool CalculateLoanEligibility()
    {
        if (balance >= 5000)
        {
            return true;
        }
        return false;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + balance);
    }
}


public class SavingsAccount : BankAccount
{
    private double interestRate;
    public double InterestRate
    {
        get { return interestRate; }
        set { interestRate = value; }
    }
    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate) : base(accountNumber, accountHolder, balance)
    {
        this.interestRate = interestRate;
    }
    public override void CalculateInterest()
    {
        double interest = Balance * interestRate / 100;
        Balance += interest;
    }

}

public class CurrentAccount : BankAccount
{
    public CurrentAccount(int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance)
    {

    }

    public override void CalculateInterest()
    {

    }
}

public class Program
{
    public static void Main()
    {
        SavingsAccount savingsAccount = new SavingsAccount(101, "John", 5000, 5);
        savingsAccount.Deposit(1000);
        savingsAccount.CalculateInterest();
        savingsAccount.DisplayDetails();
        savingsAccount.ApplyForLoan();

        CurrentAccount currentAccount = new CurrentAccount(102, "Jane", 10000);
        currentAccount.Withdraw(6000);
        currentAccount.CalculateInterest();
        currentAccount.DisplayDetails();
        currentAccount.ApplyForLoan();


    }
}


