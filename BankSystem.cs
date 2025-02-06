using System;
using System.Collections.Generic;

public class Customer
{
   public string Name;
   public int Id;
   public double Balance;
   public List<Bank> Banks;

   public Customer(string name, int id, double balance)
   {
       Name = name;
       Id = id;
       Balance = balance;
       Banks = new List<Bank>();
   }

   public void AddBank(Bank bank)
   {
       if (!Banks.Contains(bank))
       {
           Banks.Add(bank);
           bank.AddCustomer(this);
       }
   }

   public void DisplayBanks()
   {
       Console.WriteLine($"Banks associated with {Name}:");
       foreach (Bank bank in Banks)
       {
           Console.WriteLine(bank.BankName);
       }
   }

   public void ViewBalance()
   {
       Console.WriteLine($"Balance for {Name}: ${Balance}");
   }
}

public class Bank
{
   public string BankName;
   public string BankId;
   public List<Customer> Customers;
   public List<(int, double)> customerIdAndBal;
   public Bank(string bankName, string bankId)
   {
       BankName = bankName;
       BankId = bankId;
       Customers = new List<Customer>();
   }

   public void OpenAccount(Customer customer, double initialDeposit)
   {
       if (!Customers.Contains(customer))
       {
           Customers.Add(customer);
           customer.Balance += initialDeposit;
           customer.AddBank(this);
           Console.WriteLine($"Account opened successfully for {customer.Name} with an initial deposit of {initialDeposit}");
       }
       else
       {
           Console.WriteLine($"{customer.Name} already has an account in {BankName}.");
       }
   }

   public void AddCustomer(Customer customer, double balance)
   {

       if (!Customers.Contains(customer))
       {
           Customers.Add(customer);
           customerIdAndBal.Add((customer.Id, balance));
       }
   }

   public void DisplayCustomers()
   {
       Console.WriteLine($"Customers of {BankName}:");
       foreach (Customer customer in Customers)
       {
           Console.WriteLine(customer.Name);
       }
   }
}

class Program
{
   static void Main()
   {
       Bank bank1 = new Bank("ABC Bank", "001");
       Bank bank2 = new Bank("XYZ Bank", "002");

       Customer customer1 = new Customer("Alice", 1001, 5000);
       Customer customer2 = new Customer("Bob", 1002, 3000);

       bank1.OpenAccount(customer1, 1000);
       bank1.OpenAccount(customer2, 1500);
       bank2.OpenAccount(customer1, 2000);

       customer1.DisplayBanks();
       customer1.ViewBalance();

       bank1.DisplayCustomers();
       bank2.DisplayCustomers();
   }
}
