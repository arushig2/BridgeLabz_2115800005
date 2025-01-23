using System;

class FactorialWhile{
	static void Main(string[] args){
		//take input from user
		Console.Write("Enter a number: ");		
 		int n = Convert.ToInt32(Console.ReadLine());
		
		if (n > 0){ //if the number is a natural number
			long factorial = 1;
			while(n > 0){
				factorial *= n; //calculate factorial
				n--; //decrement by 1 after multiplying
			}
			
			Console.WriteLine("Factorial = " + factorial); //display the result
		} else {
			Console.WriteLine("Not a positive number");
		}	
 	}
}