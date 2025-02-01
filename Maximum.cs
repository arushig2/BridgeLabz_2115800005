using System;

class Maximum{
	static void GetInput(int[] nums){
		for(int i = 0; i < nums.Length; i++){
			Console.Write("Enter a number: ");
			nums[i] = Convert.ToInt32(Console.ReadLine());
		}
	}
	
	static int FindMaximum(int a,int b, int c){
		if(a > b && a > c){ //if a is maximum
			return a;
		} else if(b > a && b > c){ //if b is maximum
			return b;
		} else { //if c is maximum
			return c;
		}
	}
	
    static void Main(){
        int[] nums = new int[3];
		GetInput(nums); //take input  

		int maxNum = FindMaximum(nums[0], nums[1], nums[2]);
        Console.Write($"Maximum Number is: {maxNum}");
	   
    }
}
