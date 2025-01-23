using System;

class Calculator{
	static void Main(string[] args){
		//Input first and second number
		Console.Write("Enter two numbers: ");
		double first = Convert.ToDouble(Console.ReadLine());
		double second = Convert.ToDouble(Console.ReadLine());
		
		//Input the operator 
		Console.Write("Enter the operation you want to perform: \n+ for Addition \n- for Subtraction\n* for Multiplication\n/for Division\n");
		string op = Console.ReadLine();
		
		double result = 0.0;
		//switch case
		switch(op){
			case "+": // For addition
				result = first + second;
				break;
			case "-": // For Subtraction
				result = first - second;
				break;
			case "*": // For Multiplication
				result = first * second;
				break;
			case "/": // for division
				result = first / second;
				break;
			default: // if an incorrect choice is entered
				Console.WriteLine("Invalid Choice");
				break;
		}
		//display the result
		Console.WriteLine("Result: "+result);
	}
}
				
		