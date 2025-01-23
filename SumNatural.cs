using System;

class SumNatural{
	static void Main(){
		//take input from user
 		int number = Convert.ToInt32(Console.ReadLine());
		
		if(number > 0){ //if natural number
			int sum = (number * (number + 1)) / 2; //calculate sum using formula
			Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
		} else {
			Console.WriteLine("The number " + number + " is not a natural number");
		}
 	}
}