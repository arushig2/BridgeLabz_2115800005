using System;

class PrimeNumberChecker{
	static bool IsPrime(int num){
		
		for(int i = 2; i < num; i++){
			if(num % i == 0) return false; //if number is divisible by any number
		}
		
		return true;
	}
	
    static void Main(){
		Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine()); //take input from user
		
		if(IsPrime(num)){
			Console.Write("Entered number is a Prime Number");
		} else {
			Console.Write("Entered number is not a Prime Number");
		}
	   
    }
}
