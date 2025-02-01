using System;

class Reverse{
	public static void Main(string[] args){
		Console.WriteLine("Enter a number: "); //take input from user
		int number = Convert.ToInt32(Console.ReadLine());
		
		if(number < 0){ //check if number is greater than 0
			Console.WriteLine("You entered a invalid number");
			Environment.Exit(0);
		}
		
		int temp = number; //copy of original number
		int count = 0; //variable to count the number of digits
		
		while(temp != 0){
			count++; 
			temp /= 10;
		}
		
		temp = number; //copy of original number
		
		int[] revNum = new int[count];
		int ind = 0;
		
		while(temp != 0){
			int d = temp % 10; //extract last digit
			revNum[ind++] = d; //store in array
			temp /= 10;
		}
		
		Console.WriteLine("Reversed Number"); //display result	
		for(int i = 0; i < revNum.Length; i++){
			Console.Write(revNum[i]);
		}
	}
}
		
		