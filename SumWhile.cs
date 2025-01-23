using System;

class SumWhile{
	static void Main(string[] args){
		//inititalize sum to 0
		double sum = 0.0;
		//take input from user
		Console.Write("Enter a number: ");		
 		double n = Convert.ToDouble(Console.ReadLine());
		
		while(n != 0){ //run while loop till number entered by user is not 0
			sum += n; //add the number to sum
			Console.Write("Enter a number: ");
			n = Convert.ToDouble(Console.ReadLine()); //take input from user
		}
		Console.WriteLine("\nSum = " +  sum); //display result	
 	}
}