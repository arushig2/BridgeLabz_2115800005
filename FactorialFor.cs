using System;

class FactorialFor{
	static void Main(string[] args){
		//Take input from user
		Console.Write("Enter a number: ");		
 		int n = Convert.ToInt32(Console.ReadLine());
		
		if (n > 0){ //if natural number
			long factorial = 1;
			for(int i = 1; i <= n; i++){
				factorial *= i; //calculate the factorial
			}
			
			Console.WriteLine("Factorial = " + factorial); //display the results
		} else {
			Console.WriteLine("Not a natural number");
		}	
 	}
}