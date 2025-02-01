using System;

class ChocolateDistribution{
	public static int[] FindRemainderAndQuotient(int number, int divisor){
		int[] arr = new int[2];
		
		arr[0] = number / divisor; //calculate quotient --> chocolate each child gets
		arr[1] = number % divisor; //calculate remainder --> chocolate remaining
		
		return arr;
	 }
	static void Main(){
		take input from user
		Console.WriteLine("Enter number of Chocolates: ");
 		int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter a number of children: ");
 		int numberOfChildren = Convert.ToInt32(Console.ReadLine());
		
		int[] res = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren); //call method to find 
		
		Console.WriteLine("The number of chocolates each child gets is " + res[0] + " and the number of remaining chocolates is  "+res[1]);

 	}
}