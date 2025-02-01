 using System;

 class QuotientRemainder{
	 public static int[] FindRemainderAndQuotient(int number, int divisor){
		int[] arr = new int[2];
		
		arr[0] = number / divisor; //calculate quotient
		arr[1] = number % divisor; //calculate remainder
		
		return arr;
	 }
		 
 	static void Main(string[] args){
		Console.WriteLine("Enter a number: ");
 		int number = Convert.ToInt32(Console.ReadLine()); //take input from user
		Console.WriteLine("Enter a divisor: ");
		int divisor = Convert.ToInt32(Console.ReadLine());
		
		int[] res = FindRemainderAndQuotient(number, divisor); //call method to return array of quotient and remainder
		
		//display result
		Console.WriteLine("The Quotient is " + res[0] + " and Remainder is "+ res[1] + " of two numbers " + number + " and " + divisor);
  	}
 }