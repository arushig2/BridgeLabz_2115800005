using System;

class Frequency{
	public static void Main(string[] args){
		Console.WriteLine("Enter a number: "); //take input from user
		long number = Convert.ToInt64(Console.ReadLine());
		
		if(number < 0){ //check if number is greater than 0
			Console.WriteLine("You entered a invalid number");
			Environment.Exit(0);
		}
		
		long temp = number; //copy of original number		
		int[] freq = new int[10];
		
		
		while(temp != 0){
			long d = temp % 10; //extract last digit
			freq[d]++;; //update frequency in the array
			temp /= 10;
		}
		
		Console.WriteLine("Frequency of each digit"); //display result	
		for(int i = 0; i < freq.Length; i++){
			Console.WriteLine(i + ": " + freq[i]);
		}
	}
}
		
		