using System;

class BmiMulti{
	static void Main(string[] args){
		Console.WriteLine("Enter a number: "); //take input for the number of employee
		int n = Convert.ToInt32(Console.ReadLine());
		
		if(n < 0){ //check if number is greater than 0
			Console.WriteLine("You entered a invalid number");
			Environment.Exit(0);
		}
		
		double[,] personData = new double[n, 3]; //declared a 2-d array of size n X 3 to store weight, height and bmi
		string[] weightStatus = new string[n]; //declared a status array of size n
		
		for(int i = 0; i < n; i++){
			
			Console.WriteLine("Employee " + (i + 1) + ": ");
			
			take input for weight
			Console.WriteLine("Enter weight (in Kg): ");
			personData[i, 0] = Convert.ToDouble(Console.ReadLine());
			
			take input for height
			Console.WriteLine("Enter height (in m): ");
			personData[i, 1] = Convert.ToDouble(Console.ReadLine());
			
			if(personData[i, 0] <= 0 || personData[i, 1] <= 0){ //check if weight and height are valid
				Console.WriteLine("You entered a negative value, re enter a positive value");
				i--;
			}
		}
		
		for(int i = 0; i < n; i++){
			personData[i, 2] = personData[i, 0] / (Math.Pow(personData[i, 1], 2));  //calculate bmi for each employee
		
			if(personData[i, 2] <= 18.4) weightStatus[i] = "Underweight"; //store the status
			else if(personData[i, 2] <= 24.9) weightStatus[i] = "Normal";
			else if(personData[i, 2] <= 39.9) weightStatus[i] = "Overweight";
			else weightStatus[i] = "Obese";
		}
		
		Console.WriteLine();
		
		for(int i = 0; i < n; i++){ //display result
			Console.WriteLine("Employee " + (i + 1) + ": ");
			Console.Write("Weight: " +  personData[i, 0] + "\tHeight: " + personData[i, 1] + "\tBMI: " + personData[i, 2] + "\tStatus: " + weightStatus[i] + "\n"); 
		}
	}
}
		