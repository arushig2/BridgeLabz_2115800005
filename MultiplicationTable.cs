using System;

class MultiplicationTable{
	static void Main(string[] args){
		//take input from the user
		Console.Write("Enter a number: ");		
 		int n = Convert.ToInt32(Console.ReadLine());
		
		for(int i = 6; i <= 9; i++){ //run loop from 6 to 9
			int prod = n * i; // calculate the value for number * i
			Console.WriteLine(n + " X " + i + " = " + prod); //display the result
		}
 	}
}