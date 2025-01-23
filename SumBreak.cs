using System;

class SumBreak{
	static void Main(string[] args){
		//initialize sum as 0
		double sum = 0.0;
		//take input from user
		Console.Write("Enter a number: ");		
 		double n = Convert.ToDouble(Console.ReadLine());
		
		while(true){ //run the loop till it breaks itself
			sum += n; //add the given number to the sum
			Console.Write("Enter a number: ");
			n = Convert.ToDouble(Console.ReadLine()); //take input from user
			if(n <= 0) break; // if number is 0 or negative break out of loop
		}
		Console.WriteLine("\nSum = " +  sum); //display result
 	}
}