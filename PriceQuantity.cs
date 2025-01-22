 using System;

 class PriceQuantity{
 	static void Main(string[] args){
		
 		double unitPrice = Convert.ToDouble(Console.ReadLine());
		double quantity = Convert.ToDouble(Console.ReadLine());
		double totalPrice = unitPrice * quantity;
				
		Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
  	}
 }
 
 