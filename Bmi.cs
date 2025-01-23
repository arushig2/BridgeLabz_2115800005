using System;

class Bmi{
	static void Main(string[] args){
		//take input for weight
		Console.WriteLine("Enter weight (in Kg): ");
		double weight = Convert.ToDouble(Console.ReadLine());
		//take input for height
		Console.WriteLine("Enter height (in cm): ");
		double height = Convert.ToDouble(Console.ReadLine());
		
		double heightInMetres = height / 100; //convert height in cm to metres
		
		double bmi = weight / (heightInMetres * heightInMetres); //calcualte bmi

		//display result based on bmi score		
		if(bmi <= 18.4) Console.WriteLine("Underweight");
		else if(bmi <= 24.9) Console.WriteLine("Normal");
		else if(bmi <= 39.9) Console.WriteLine("Overweight");
		else Console.WriteLine("Obese");
		
	}
}
		