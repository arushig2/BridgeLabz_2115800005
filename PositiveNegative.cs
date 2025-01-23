using System;

class PositiveNegative{
	static void Main(string[] args){
		//take input from user
 		int n = Convert.ToInt32(Console.ReadLine());
			
		if(n > 0){ //if number is greater than 0
			Console.WriteLine("Positve");
		} else if(n < 0){ // if number is less than 0
			Console.WriteLine("Negative");
		} else{ //if number is equals to 0
			Console.WriteLine("Zero");
		}
 	}
}