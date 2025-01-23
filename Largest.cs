using System;

class Largest{
	static void Main(){
		// Read three integers from the user
 		int number1 = Convert.ToInt32(Console.ReadLine());
		int number2 = Convert.ToInt32(Console.ReadLine());
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		 // Variables to store the answers for each number
		string ans1, ans2, ans3;
		
		 // Check if the first number is the largest
		if(number1 > number2 && number1 > number3){
			ans1 = "Yes";
			ans2 = "No";
			ans3 = "No";
		} else if(number2 > number1 && number2 > number3){ // Check if the second number is the largest
			ans1 = "No";
			ans2 = "Yes";
			ans3 = "No";
		} else { Otherwise, the third number is the largest
			ans1 = "No";
			ans2 = "No";
			ans3 = "Yes";
		}
		
		 // Output the results for each number		
		Console.WriteLine("Is the first number the largest? " + ans1);
		Console.WriteLine("Is the second number the largest? "+ans2);
		Console.WriteLine("Is the third number the largest? " +ans3);			
 	}
}