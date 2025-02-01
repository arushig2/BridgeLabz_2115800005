// using System;

// class GradesMulti{
	// static void Main(string[] args){
		
		// Console.WriteLine("Enter a number: "); //take input for the number of employee
		// int n = Convert.ToInt32(Console.ReadLine());
		
		// if(n < 0){ //check if number is greater than 0
			// Console.WriteLine("You entered a invalid number");
			// Environment.Exit(0);
		// }
		
		// double[,] score = new double[n,3]; //declared a 2-d score array of size n
		// double[] percentage = new double[n]; //declared a percentage array of size n
		// string[] grade = new string[n]; //declared a grades array of size n
		
		// for(int i = 0; i < n; i++){
			// Console.WriteLine("Student " + (i + 1) + ": ");
			//take input for marks from the user
			// Console.Write("\nEnter Maths Marks: ");
			// double m = double.Parse(Console.ReadLine());
			// Console.Write("\nEnter Physics Marks: ");
			// double p = double.Parse(Console.ReadLine());
			// Console.Write("\nEnter Chemistry Marks: ");
			// double c = double.Parse(Console.ReadLine());
			
			// if(m < 0 || p < 0 || c < 0 || m > 100 || p > 100 || c > 100){ //invalid value
				// Console.WriteLine("You entered a invalid value, re enter a valid value");
				// i--;
				// continue;
			// }
			
			// score[i, 0] = m;
			// score[i, 1] = c;
			// score[i, 2] = p;
		// }
		// Console.WriteLine();
		// for(int i= 0; i < n; i++){
			// double sum = score[i, 0] + score[i, 1] + score[i, 2];
			// percentage[i] = (sum / 300 ) * 100; //calculate percentage
			
			// if(percentage[i] >= 80){ //check according to the given conditions
				// grade[i] = "A";//assign grade
			// } else if(percentage[i] >= 70){
				// grade[i] = "B";
			// } else if(percentage[i] >= 60){
				// grade[i] = "C";
			// } else if(percentage[i] >= 50){
				// grade[i] = "D";
			// } else if(percentage[i] >= 40){
				// grade[i] = "E";
			// } else {
				// grade[i] = "R";
			// }
		// }
		
		// for(int i = 0; i < n; i++){ //display result
			// Console.WriteLine("Student " + (i + 1) + ": ");
			// Console.Write("Maths: " +  score[i, 0] + "\tPhysics: " + score[i, 1] + "\tChemistry: " + score[i, 2] + "\tPercentage: " + percentage[i] +"\tGrade: " + grade[i] + "\n"); 
		// }		
		
	// }
// }