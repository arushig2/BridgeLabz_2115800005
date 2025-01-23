using System;

class Multiples{
	static void Main(string[] args){
		//take input from user
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		//run loop from 100 till 1 and find all numbers that are multiples of n
		for(int i = 100; i >= 1; i--){
			if(i % n == 0){
				Console.WriteLine(i);
				continue;
			}
		}
	}
}