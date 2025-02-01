using System;

class SumComparisonFor{
	static int CalculateSum(int n){
		int calculatedSum = 0;
		for(int i = 1; i <= n; i++){
			calculatedSum += i; //caluclate sum using for loop
		}
		
		return calculatedSum;
	}
			
	static void Main(string[] args){
		//take input from user
		Console.Write("Enter a number: ");		
 		int n = Convert.ToInt32(Console.ReadLine());
		
		if (n <= 0){ //if not a natural number
			Console.WriteLine("Not a natural number");
			Environment.Exit(0);
		}
		
		int sum = CalculateSum(n);
		//display result
		Console.WriteLine("Sum: " + sum);
		
 	}
}