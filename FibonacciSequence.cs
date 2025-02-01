using System;

class FibonacciSequence{
	static void GenerateFibonacci(int n){
		int a = 0, b = 1; //initialize the starting two terms
		
		Console.Write($"{a} {b} ");
		for(int i = 3; i <= n; i++){
			int c = a + b; //sum of pervious two terms
			a = b; // update a
			b = c; //update c
			
			Console.Write($"{c} ");
		}
	}
	
    static void Main(){
		Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine()); //take input from user
		
		Console.Write("Fibonacci Series: ");
		GenerateFibonacci(n);//call function to generate fibonacci series
	   
    }
}
