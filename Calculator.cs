 using System;

 class Calculator{
 	static void Main(string[] args){
		
 		float a = float.Parse(Console.ReadLine());
		float b = float.Parse(Console.ReadLine());
		
		float addition = a + b;
		float subtraction = a - b;
		float division = a / b;
		float multiplication = a * b;
		
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " 
		+ a + " and " + b + " is " + addition + ", " + subtraction + ", " + multiplication + " and " + division);
  	}
 }