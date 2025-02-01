using System;

class NumberComparisons{
	public static bool isPositive(int n){
		if(n < 0){ //if number is negative
			return false;
		} else {  
			return true;//if number is positive
		}
	}

	public static bool isEven(int n){
		if(n % 2 == 0){ //check if number is even
			return true;
		} else { //check if number is odd
			return false;
		}
	}
	
	public static int compare(int a, int b){
		if(a > b) return 1;
		else if(a == b) return 0;
		else return -1;
	}
	
	
	public static void Main(string[] args){
		int[] nums = new int[5]; //declare and array of size 5
		
		for(int i = 0; i < nums.Length; i++){
		Console.Write("Enter value for index " + i + ":");
			nums[i] = Convert.ToInt32(Console.ReadLine()); //take input from user
		}
		
		for(int i = 0; i < nums.Length; i++){
			if(isPositive(nums[i])){
				Console.WriteLine(nums[i] + " is positive");
				if(isEven(nums[i])){
					Console.WriteLine(nums[i] + " is even");
				} else {
					Console.WriteLine(nums[i] + " is odd");
				}
			} else {
				Console.WriteLine(nums[i] + " is negative");
			}
		}
		
		Console.WriteLine("Comparing the first and last element of the array: " );
		int res = compare(nums[0], nums[^1]);
		
		if(res == 1){
			Console.WriteLine("First element " + nums[0] + " is greater than last element " + nums[^1]);
		} else if(res == -1){
			Console.WriteLine("First element " + nums[0] + " is lesser than last element " + nums[^1]);
		} else {
			Console.WriteLine("First element " + nums[0] + " is equal to the last element " + nums[^1]);
		}
		
	}
}