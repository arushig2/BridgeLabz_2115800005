using System;

class Power{
	static void Main(string[] args){
		//take input a number 
		Console.Write("Enter base: ");
		int n = Convert.ToInt32(Console.ReadLine());
		//take input the power to be calculated
		Console.Write("Enter exponent: ");
		int power = Convert.ToInt32(Console.ReadLine());
		long result = 1;
		
		//run a loop from 1 till power and multiply the number to resultant
		for(int i = 1; i <= power; i++){
			result *= n;
		}
		Console.Write("Result = " + result);
	}
}