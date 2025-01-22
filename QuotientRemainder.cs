 using System;

 class QuotientRemainder{
 	static void Main(string[] args){
		
 		double a = Convert.ToDouble(Console.ReadLine());
		double b = Convert.ToDouble(Console.ReadLine());
		double quo = a / b;
		double rem = a % b;
		
		Console.WriteLine("The Quotient is " + quo + " and Remainder is "+ rem + " of two numbers " + a + " and " + b);
  	}
 }