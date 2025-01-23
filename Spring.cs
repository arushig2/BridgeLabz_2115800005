using System;

class Spring{
	static void Main(string[] args){
		//take input for month number and date
 		int month = Convert.ToInt32(Console.ReadLine());
		int date = Convert.ToInt32(Console.ReadLine());
		
		//check if the month and date lies between March20 and June 20
		if((month == 3 && date >= 20) || (month == 6  && date <= 20) || (month > 3 && month < 6)){ 
			Console.WriteLine("Its a Spring Season");
		} else { //otherwise not a spring season
			Console.WriteLine("Not a Spring Season");			
		}	
 	}
}