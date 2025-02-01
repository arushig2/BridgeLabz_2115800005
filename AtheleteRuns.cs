using System;

class AtheleteRuns{
	static int Rounds(int side1, int side2, int side3, int distance){
		
		int perimeter = side1 + side2 + side3; //calculate perimeter
		int rounds = distance / perimeter; //calculate number of rounds
		
		return rounds; //return number of rounds
	}		
		
	static void Main(){
		Console.WriteLine("Enter sides of the triangle: "); //take input for sides from user
 		int side1 = Convert.ToInt32(Console.ReadLine());
 		int side2 = Convert.ToInt32(Console.ReadLine());
 		int side3 = Convert.ToInt32(Console.ReadLine());
		
		int distance = 5;
		
		int rounds = Rounds(side1, side2, side3, distance); //Call method to calculate rounds
		
		//display result
		Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");

 	}
}