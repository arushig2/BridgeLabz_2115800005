using System;

class SmallestLargest{
	public static int[] FindSmallestAndLargest(int number1, int number2, int number3){
		int[] res = new int[2];
		
		if(number1 < number2 && number1 < number3){ //check if first number is smallest
			res[0] = number1;
		} else if(number2 < number1 && number2 < number3){ //check if second number is smallest
			res[0] = number2;
		} else { //else third number is smallest
			res[0] = number3;
		}
		
		if(number1 > number2 && number1 > number3){ //check if first number is largest
			res[1] = number1;
		} else if(number2 > number1 && number2 > number3){ //check if second number is largest
			res[1] = number2;
		} else { //else third number is largest
			res[1] = number3;
		}
		
		return res;
			
	 }
	static void Main(){
		//take input from user
		Console.WriteLine("Enter three numbers: ");
 		int number1 = Convert.ToInt32(Console.ReadLine());
		int number2 = Convert.ToInt32(Console.ReadLine());
		int number3 = Convert.ToInt32(Console.ReadLine());
		
		int[] res = FindSmallestAndLargest(number1, number2, number3); //call method to find smallest and largest
		
		Console.WriteLine("The smallest number is " + res[0] + " and the largest number is  "+res[1]);

 	}
}