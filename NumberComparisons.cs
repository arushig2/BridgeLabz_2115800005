using System;

class NumberComparisons{
	public static void Main(string[] args){
		int[] nums = new int[5]; //declare and array of size 5
		
		for(int i = 0; i < nums.Length; i++){
		Console.Write("Enter value for index " + i + ":");
			nums[i] = Convert.ToInt32(Console.ReadLine()); //take input from user
		}
		
		for(int i = 0; i < nums.Length; i++){
			if(nums[i] < 0){ //if number is negative
				Console.WriteLine(nums[i] + " is a negative number");
			} else {  //if number is positive
				Console.Write(nums[i] + " is a positive number and is ");
				if(nums[i] % 2 == 0){ //check if number is even
					Console.Write("even\n");
				} else { //check if number is odd
					Console.Write("odd\n");
				}
			}
		}
		
		comparing the first and last element of the array
		if(nums[0] > nums[^1]){
			Console.WriteLine("First element " + nums[0] + " is greater than last element " + nums[^1]);
		} else if(nums[0] < nums[^1]){
			Console.WriteLine("First element " + nums[0] + " is lesser than last element " + nums[^1]);
		} else {
			Console.WriteLine("First element " + nums[0] + " is equal to the last element " + nums[^1]);
		}
		
	}
}