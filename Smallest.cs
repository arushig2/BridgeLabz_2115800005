using System;

class Smallest{
	static void Main(){
		// Read three integers from the user
 		int number1 = Convert.ToInt32(Console.ReadLine());
		int number2 = Convert.ToInt32(Console.ReadLine());
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Is the first number the smallest? ");
		
		// Check if the first number is smaller than both the second and third numbers
		if(number1 < number2 && number1 < number3){
			Console.Write("Yes");
		} else {
			Console.Write("No");
		}
 	}
}