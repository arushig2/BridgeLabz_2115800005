using System;

class Factorial{
	static int GetInput(){
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine()); //take input from use
		return num;
	}
	
	static int FindFactorial(int num){
		if(num == 1) return 1; //base case
		
		return num * FindFactorial(num - 1);//recursive call
	}
	
	static void Output(int ans){
		Console.WriteLine($"Factorial is {ans}"); //display output
	}
	
    static void Main(){
		
        int num = GetInput(); //take input from user
		int ans = FindFactorial(num); //calculate factorial
		Output(ans); //display output
	   
    }
}
