using System;

class OddEven{
	static void Main(string[] args){
		//take input fromt the user
		Console.Write("Enter a number: ");		
 		int n = Convert.ToInt32(Console.ReadLine());
		
		if (n > 0){ //check if naturalnumber
			
			for(int i = 1; i <= n; i++){ //run loop from 1 to n
				
				if(i % 2 == 0){ //if even
					Console.WriteLine(i + " is even");
				} else { // if odd
					Console.WriteLine(i + " is odd");
				}
			}
		} else {
			Console.WriteLine("Not a natural number");
		}	
 	}
}