using System;

class Calculator{
	static double GetInput(){
		Console.Write("Enter a number: ");
		double num = Convert.ToDouble(Console.ReadLine()); //take input from use
		return num;
	}
	
	static double Addition(double first, double second){
		double result = first + second;
		return result;//recursive call
	}
	static double Subtraction(double first, double second){
		double result = first - second;
		return result;//recursive call
	}
	static double Multiplication(double first, double second){
		double result = first * second;
		return result;//recursive call
	}
	static double Division(double first, double second){
		double result = first / second;
		return result;//recursive call
	}
	
	static void Output(double result){
		Console.WriteLine($"Result is {result}"); //display output
	}
	
	static void Main(string[] args){
		Input first and second number
		double first = GetInput();
		double second = GetInput();
		
		Input the operator 
		Console.Write("Enter the operation you want to perform: \n+ for Addition \n- for Subtraction\n* for Multiplication\n/for Division\n");
		string op = Console.ReadLine();
		
		double result = 0.0;
		switch case
		switch(op){
			case "+": // For addition
				result = Addition(first, second);
				break;
			case "-": // For Subtraction
				result = Subtraction(first, second);
				break;
			case "*": // For Multiplication
				result = Multiplication(first, second);
				break;
			case "/": // for division
				result = Division(first, second);
				break;
			default: // if an incorrect choice is entered
				Console.WriteLine("Invalid Choice");
				break;
		}
		display the result
		Output(result);
	}
}
				
		