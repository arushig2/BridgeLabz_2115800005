using System;

class GreatestFactor{
	static void Main(string[] args){
		//take input from the user
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		int greatestFactor = 1; //initialize greatestFactor to 1
		
		//run a loop from n - 1 to 1 in reverse order
		for(int i = n - 1; i >= 1; i--){
			if(n % i == 0){ //if n is divisible by i we have found the greatest factor
				greatestFactor = i;
				break; //break out of for loop
			}
		}
		Console.Write("Greatest Factor = " + greatestFactor); //display result
	}
}