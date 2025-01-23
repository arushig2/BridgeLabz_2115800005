using System;

class Prime{
	static void Main(string[] args){
		//take input a number from user
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		if(n >= 1){//check if natural
			bool isPrime = true; //flag to check if number is prime
			
			//run a loop from 2 till n - 1
			for(int i = 2; i < n; i++){
				if(n % i == 0){ //if number is divisible by another number it is not a prime number
					isPrime = false;
					break; //break out of loop
				}
			}
			 
			if(isPrime){ //if isPrime is true print prime number
				Console.WriteLine("Prime Number");
			} else {
				Console.WriteLine("Not a Prime Number");
			}
		} else {
			Console.WriteLine("Enter a valid number");
		}
	}
}