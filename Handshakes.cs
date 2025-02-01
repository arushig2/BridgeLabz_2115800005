 using System;

 // class Handshakes{
	static int NumberOfHandshakes(int n){
		int totalHandshakes = (n * (n - 1)) / 2; //calculate number of handshakes
		
		return totalHandshakes;//return total handshakes
	}
 	static void Main(string[] args){
		Console.WriteLine("Enter number of persons ");
 		int n = int.Parse(Console.ReadLine()); //take input from user
		
		int totalHandshakes = NumberOfHandshakes(n); //call function to calculate total handshakes
		
		//display result		
		Console.WriteLine("The total number of handshakes " + totalHandshakes);
  	}
 }