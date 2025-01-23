using System;

class Factors{
	static void Main(string[] args){
		//take input from user
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		//run loop from 1 till n - 1
		for(int i = 1; i < n; i++){
			if(n % i == 0){ //check if number is a factor
				Console.WriteLine(i);//display factors
				continue;
			}
		}
	}
}