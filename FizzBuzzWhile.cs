using System;

class FizzBuzzWhile{
	static void Main(string[] args){
		//take input from user
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		int i = 0;
		
		while(i != n){ //run while loop from 0 till n
			if(i % 3 == 0 && i % 5 == 0){ //check if number is divisible by 3 and 5
				Console.WriteLine("FizzBuzz");
			} else if(i % 3 == 0){ // check if number is divisible by 3
				Console.WriteLine("Fizz");
			} else if(i % 5 == 0){ // check if number is divisible by 5
				Console.WriteLine("Buzz");
			} else { 
				Console.WriteLine(i);
			}
			i++; //increment
		}
	}
}