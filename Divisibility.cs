using System;

class Divisibility{
	static void Main(){
		// Read an integer number from the user
 		int number = Convert.ToInt32(Console.ReadLine());
		Console.Write("Is the number " + number +  " divisible by 5?  ");
		// Check if the number is divisible by 5
 		if(number % 5 == 0){
			Console.Write("Yes"); //divisible
		}else {
			Console.Write("No"); //not divisible
		}

 	}
}