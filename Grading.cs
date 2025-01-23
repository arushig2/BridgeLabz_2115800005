using System;

class Grading{
	static void Main(string[] args){
		//take input for marks from the user
		Console.Write("\nEnter Maths Marks: ");
		int math = int.Parse(Console.ReadLine());
		Console.Write("\nEnter Physics Marks: ");
		int phy = int.Parse(Console.ReadLine());
		Console.Write("\nEnter Chemistry Marks: ");
		int chem = int.Parse(Console.ReadLine());
		
		double sum = math + phy + chem; //calculate the sum
		
		double percentage = (sum / 300 ) * 100; //calculate the percentage marks
		Console.WriteLine("Percentage Marks: " + percentage);
		
		if(percentage >= 80){ //check according to the given conditions
			Console.WriteLine("Grade: A"); //display grade and remarks
			Console.WriteLine("Remarks: Level 4, above agency normalized standards");
		} else if(percentage >= 70){
			Console.WriteLine("Grade: B");
			Console.WriteLine("Remarks: Level 3, at agency normalized standards");
		} else if(percentage >= 60){
			Console.WriteLine("Grade: C");
			Console.WriteLine("Remarks: Level 2, below but approaching agency normalized standards");
		} else if(percentage >= 50){
			Console.WriteLine("Grade: D");
			Console.WriteLine("Remarks: Level 1, well below approaching agency normalized standards");
		} else if(percentage >= 40){
			Console.WriteLine("Grade: E");
			Console.WriteLine("Remarks: Level 1-, too below approaching agency normalized standards");
		} else {
			Console.WriteLine("Grade: R");
			Console.WriteLine("Remarks: Remedial standards");
		}
	}
}