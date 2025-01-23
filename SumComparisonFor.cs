using System;

class SumComparisonFor{
	static void Main(string[] args){
		//take input from user
		Console.Write("Enter a number: ");		
 		int n = Convert.ToInt32(Console.ReadLine());
		
		if (n > 0){ //if natural number
			int formulaSum = (n * (n + 1)) / 2; //calculte sum using formula
			int calculatedSum = 0;
			
			for(int i = 1; i <= n; i++){
				calculatedSum += i; //caluclate sum using for loop
			}
			
			//display result
			Console.WriteLine("Sum calculated using formula = " + formulaSum);
			Console.WriteLine("Sum calculated using while loop = " + calculatedSum);
		} else {
			Console.WriteLine("Not a natural number");
		}	
 	}
}