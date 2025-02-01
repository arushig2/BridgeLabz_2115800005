using System;

class Spring{
	static bool IsSpring(int month, int date){
		//check if the month and date lies between March20 and June 20
		if((month == 3 && date >= 20) || (month == 6  && date <= 20) || (month > 3 && month < 6)){ 
			return true;
		} else { //otherwise not a spring season
			return false;
		}
	}		
	static void Main(string[] args){
		//take input for month number and date
		Console.WriteLine("Enter a Month and Date: ");
 		int month = Convert.ToInt32(Console.ReadLine());
		int date = Convert.ToInt32(Console.ReadLine());
		
		bool res = IsSpring(month, date);
		
		//display result 
		if(res) Console.WriteLine("Its a Spring Season");
		else Console.WriteLine("Not a Spring Season");	
 	}
}