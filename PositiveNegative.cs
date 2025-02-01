using System;

class PositiveNegative{
	static int PositiveNegativeOrZero(int n){
		if(n > 0){ //if number is greater than 0
			return 1;
		} 
		else if(n < 0){ // if number is less than 0
			return -1;
		} 
		else{ //if number is equals to 0
			return 0;
		}
	}
	static void Main(string[] args){
		//take input from user
		Console.WriteLine("Enter a number: ");
 		int n = Convert.ToInt32(Console.ReadLine());
		
		int ans = PositiveNegativeOrZero(n);
		
		if(ans == -1){ //if returned value is -1
			Console.WriteLine("Negative");
		} 
		else if(ans == 0){ // if returned value is 1
			Console.WriteLine("Zero");
		} 
		else{ //if returned value is 0
			Console.WriteLine("Positive");
		}
		
 	}
}