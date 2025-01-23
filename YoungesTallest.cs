using System;

class YoungesTallest{
	static void Main(string[] args){
		//eneter details for amar
		Console.WriteLine("Enter Age and Height of Amar");
		int amarAge = Convert.ToInt32(Console.ReadLine());
		int amarHeight = Convert.ToInt32(Console.ReadLine());
		//enter details for akbar
		Console.WriteLine("Enter Age and Height of Akbar");
		int akbarAge = Convert.ToInt32(Console.ReadLine());
		int akbarHeight = Convert.ToInt32(Console.ReadLine());
		//enter details for anthony
		Console.WriteLine("Enter Age and Height of Anthony");
		int anthonyAge = Convert.ToInt32(Console.ReadLine());
		int anthonyHeight = Convert.ToInt32(Console.ReadLine());
		
		string youngestFrnd, tallestFrnd;
		
		if(akbarAge < amarAge && akbarAge < anthonyAge){ //check if akbar is youngest
			youngestFrnd = "Akbar";
		} else if(amarAge < akbarAge && amarAge < anthonyAge){ //check if amar is youngest
			youngestFrnd = "Amar";
		} else { //otherwise anthony is youngest
			youngestFrnd = "Anthony";
		}
		
		if(amarHeight > akbarHeight && amarHeight > anthonyHeight){ //check if amar is tallest
			tallestFrnd = "Amar";
		} else if(akbarHeight > amarHeight && akbarHeight > anthonyHeight){ // check if akbar is tallest
			tallestFrnd = "Akbar";
		} else { //otherwise anthony is tallest
			tallestFrnd = "Anthony";
		}
		//display result
		Console.WriteLine("Youngest Friend: "+youngestFrnd);
		Console.WriteLine("Tallest Friend: "+tallestFrnd);
	}
}
		
		
		
		
	