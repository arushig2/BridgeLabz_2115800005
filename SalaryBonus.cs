// using System;

// class SalaryBonus{
	// static void Main(string[] args){
		
		// double[] salary = new double[10]; //declare salary array of size 10
		// double[] years = new double[10]; //declare years array of size 10
		
		// for(int i = 0; i < salary.Length; i++){ //populate salary and years array
			
			// Console.WriteLine("Employee: " + (i + 1));
			
			// Console.Write("Enter salary: ");		
			// double s = Convert.ToDouble(Console.ReadLine()); //take input for salary
			
			// Console.Write("Enter years of service: ");
			// double y = Convert.ToDouble(Console.ReadLine()); //take input for years
			
			// if(s <= 0 || y <= 0){ //if invalid salary or year
				// Console.WriteLine("Invalid Input, Kindly enter again!");
				// i--; //counter decrement
				// continue;
			// }
			
			// salary[i] = s; //assign salary
			// years[i] = y; //assign years
		// }
		
		// double[] bonus = new double[10]; //declare bonus array of size 10
		// double[] newSalary = new double[10]; //declare newSalary array of size 10
		
		// double totalBonus = 0.0; //variable declaration to 0
		// double totalOldSalary = 0.0;
		// double totalNewSalary = 0.0;
 
		// for(int i = 0; i < salary.Length; i++){
			// if(years[i] > 5){ //if years of service greater than 5
				// bonus[i] = salary[i] * 5 / 100; 
			// } else { //if years of service less than 5
				// bonus[i] = salary[i] * 2 / 100;
			// }
			
			// newSalary[i] = salary[i] + bonus[i]; //calculate new salary
			// totalBonus += bonus[i]; //calculate total bonus
			// totalOldSalary += salary[i]; //calculate total old salary
			// totalNewSalary += newSalary[i]; //calculate total new salary
		// }
		
		
		// for(int i = 0; i < salary.Length; i++){ //display bonus and new salary of each employee
			// Console.WriteLine("Employee: " + (i + 1));
			// Console.WriteLine("Bonus: " + bonus[i]);				
			// Console.WriteLine("New Salary: " + newSalary[i]);
		// }
		
		//display result
		// Console.WriteLine("\nTotal Bonus Payout: " + totalBonus);
		// Console.WriteLine("Total old salary: " + totalOldSalary);
		// Console.WriteLine("Total new salary: " + totalNewSalary);
		
 	// }
// }