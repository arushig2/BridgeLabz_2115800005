using System;

class FizzBuzz{
	static void Main(string[] args){
		//take input from user
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		//run a loop from 0 till n
		for(int i = 0; i <= n; i++){
			if(i % 3 == 0 && i % 5 == 0){ //check if number is divisble by both 3 and 5
				Console.WriteLine("FizzBuzz");
			} else if(i % 3 == 0){ //check if number is divisible by 3
				Console.WriteLine("Fizz");
			} else if(i % 5 == 0){ // check if number is divisible by 5
				Console.WriteLine("Buzz");
			} else {
				Console.WriteLine(i); //if number is not divisible print the number itself
			}
		}
	}
}