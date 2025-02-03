using System;

public class BankAccount
{
   public long accountNumber;
   protected string accountHolder;
   private double balance;

   public double GetBalance()
   {
       return balance;
   }

   public void SetBalance(double amount)
   {
       balance = amount;
   }

   public BankAccount() { }

   public BankAccount(long accountNumber, string accountHolder, double balance)
   {
       this.accountNumber = accountNumber;
       this.accountHolder = accountHolder;
       this.balance = balance;
   }

   public void DisplayAccountDetails()
   {
       Console.WriteLine("Bank Account Details:");
       Console.WriteLine($"Account Number: {accountNumber}");
       Console.WriteLine($"Account Holder: {accountHolder}");
       Console.WriteLine($"Balance: {GetBalance()}"); // Access balance using GetBalance()
   }
}

public class SavingsAccount : BankAccount
{
   public double interestRate;

   public SavingsAccount(long accountNumber, string accountHolder, double balance, double interestRate)
       : base(accountNumber, accountHolder, balance)
   {
       this.interestRate = interestRate;
   }

   public void DisplayInfo()
   {
       Console.WriteLine("Savings Account Details:");
       Console.WriteLine($"Account Number: {accountNumber}"); 
       Console.WriteLine($"Account Holder: {accountHolder}"); 
       Console.WriteLine($"Balance: {GetBalance()}"); // Private member (Accessed via method)
       Console.WriteLine($"Interest Rate: {interestRate}%");
   }
}


public class Program
{
   public static void Main(string[] args)
   {

       BankAccount acc1 = new BankAccount(101234567, "John Doe", 5000);
       acc1.DisplayAccountDetails();

       acc1.SetBalance(6000);
       acc1.DisplayAccountDetails();
       Console.WriteLine($"Accessing Balance outside class via method: {acc1.GetBalance()}");

       SavingsAccount savAcc = new SavingsAccount(102345678, "Alice Brown", 8000, 3.5);
       savAcc.DisplayInfo(); 

       savAcc.SetBalance(9000);
       savAcc.DisplayAccountDetails(); 
       Console.WriteLine($"Updated Balance: {savAcc.GetBalance()}");
   }
}
