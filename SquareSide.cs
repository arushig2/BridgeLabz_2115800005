 using System;

 class SquareSide{
 	static void Main(string[] args){
		
 		int perimeter = int.Parse(Console.ReadLine());
		int side = perimeter / 4;
		
		Console.WriteLine("The length of the side is " +side +" whose perimeter is "+perimeter);
  	}
 }