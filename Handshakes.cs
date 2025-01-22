 using System;

 class Handshakes{
 	static void Main(string[] args){
		
 		int n = int.Parse(Console.ReadLine());
		int totalHandshakes = (n * (n - 1)) / 2;
		
		Console.WriteLine("The total number of handshakes " + totalHandshakes);
  	}
 }