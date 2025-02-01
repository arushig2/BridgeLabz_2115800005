using System;

class Factors{
	public static int[] StoreFactors(int n){
		int sizeArray = 0;
		for(int i = 1; i <= n; i++){  //run a loop from 1 till n
			if(n % i == 0){ 
				sizeArray++;
				}
		}
		
		int[] arr = new int[sizeArray];
		int ind = 0;
		
		for(int i = 1; i <= n; i++){  //run a loop from 1 till n
			if(n % i == 0){ 
					arr[ind++] = i;
				}
		}
		
		return arr;
	}
	
	static int SumOfFactors(int[] factors){
		int sum = 0;
		
		for(int i = 0; i < factors.Length; i++){
			sum += factors[i];
		}
		
		return sum;
	}
		
	static long ProductOfFactors(int[] factors){
		long prod = 1;
		
		for(int i = 0; i < factors.Length; i++){
			prod *= factors[i];
		}
		
		return prod;
	}
	
	static int SquareSum(int[] factors){
		int sum = 0;
		
		for(int i = 0; i < factors.Length; i++){
			sum += (int)Math.Pow(factors[i], 2);
		}
		
		return sum;
	}
		
	public static void Main(string[] args){
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine()); //take input from user
		
		int[] factors = StoreFactors(n);
		int sum = SumOfFactors(factors);
		long product = ProductOfFactors(factors);
		int sumOfSquare = SquareSum(factors);
		
		Console.Write("Factors: ");
		for(int i = 0; i < factors.Length; i++){
			Console.Write(factors[i] + " ");
		}
		Console.WriteLine("\nSum of factors: " + sum);
		Console.WriteLine("Product of factors: " + product);
		Console.WriteLine("Sum of square of factors: " + sumOfSquare);
		
	}
}
