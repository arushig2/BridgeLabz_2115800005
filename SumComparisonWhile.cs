using System;

class SumComparisonWhile{
	static void Main(string[] args){
		//take input from the user
		Console.Write("Enter a number: ");		
 		int n = Convert.ToInt32(Console.ReadLine());
		
		if (n > 0){ //if natural number
			int formulaSum = (n * (n + 1)) / 2; //calculate sum using formula
			int calculatedSum = 0;
			while(n >= 1){
				calculatedSum += n; //calculate sum using while loop
				n--;
			}
			
			//result
			Console.WriteLine("Sum calculated using formula = " + formulaSum);
			Console.WriteLine("Sum calculated using while loop = " + calculatedSum);
		} else {
			Console.WriteLine("Not a natural number");
		}	
 	}
}