using System;

 class UniFeesUser{
 	static void Main(string[] args){
		
 		double fee = double.Parse(Console.ReadLine());
  		double discountPercent = double.Parse(Console.ReadLine());
  		double discount = fee * (discountPercent / 100);
		double feeToPay = fee - discount;
		
 		Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR "+feeToPay);

  	}
 }