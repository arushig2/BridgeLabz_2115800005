using System;

class SumNatural{
	static int SumFormula(int n){
		int sum = n * (n + 1) / 2;
		return sum;
	}
	
	static int SumRecursion(int n){
		if(n == 1) return 1;
		
		return n + SumRecursion(n - 1);
	}
		
		
	public static void Main(string[] args){
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine()); //take input from user
		
		if(n <= 0){
			Console.WriteLine("Incorrect input");
			Environment.Exit(0);
		}
		
		
		int sumFormula = SumFormula(n);
		long sumRecursion = SumRecursion(n);
		
		Console.WriteLine("Sum of naturals number using formula: " + sumFormula);
		Console.WriteLine("Sum of naturals number using recursion: " + sumRecursion);
		
	}
}
