//using System;

//class BankAccount
//{
//    public static string bankName = "Bank Of India";
//    public static int totalBankAccounts = 0;
//    public string AccountHolderName;
//    public readonly int AccountNumber;

//    public BankAccount(string AccountHolderName, int AccountNumber)
//    {
//        this.AccountHolderName = AccountHolderName;
//        this.AccountNumber = AccountNumber;
//        totalBankAccounts++;
//    }

//    public static void GetTotalAccount()
//    {
//        Console.WriteLine($"Total Accounts in bank are: {totalBankAccounts}");
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Bank Name: {bankName}");
//        Console.WriteLine($"Account Holder name: {AccountHolderName}");
//        Console.WriteLine($"Bank Account Number: {AccountNumber}");
//    }    
    
//}

//public class Temp
//{
//    public Temp() { }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        BankAccount account1 = new BankAccount("Ravi", 453);
//        account1.Display();
//        // account1.AccountNumber = 543; //error as read only variable

//        BankAccount account2 = new BankAccount("Sunita", 568);
//        account2.Display();

//        BankAccount.GetTotalAccount();

//        Temp temp = new Temp();

//        if (temp is BankAccount)
//        {
//            Console.WriteLine("An instance of BankAccount");
//        } else
//        {
//            Console.WriteLine("Not an instance of BankAccount");
//        }
//    }
//}

