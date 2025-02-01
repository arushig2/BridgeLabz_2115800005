using System;

class YoungestAndTallest{
	public static void Main(string[] args){
		
		int[] age = new int[3]; //declare salary array of size 10
		int[] height = new int[3]; 
		string[] names = {"Amar", "Akbar", "Anthony"};
		
		// 0 - Amar 
		// 1 - Akbar
		// 2 - Anthony
		
		for(int i = 0; i < salary.Length; i++){ 
			Console.WriteLine("Enter Age and Height of " + names[i]);
			age[i] = Convert.ToInt32(Console.ReadLine());
			height[i] = Convert.ToInt32(Console.ReadLine());
			
			if(age[i] <= 0 || height[i] <= 0){
				Console.WriteLine("You entered a invalid number");
				Environment.Exit(0);
			}
		}		
		
		int youngestFrnd, tallestFrnd;
		int minAge = int.MaxValue;
		int maxHeight = 0;
		
		for(int i = 0; i < age.Length; i++){
			if(age[i] < minAge){
				minAge = age[i];
				youngestFrnd = i;
			} 
			if(height[i] > maxHeight){
				maxHeight = height[i];
				tallestFrnd = i;
			}
		}
		
		//display result
		Console.WriteLine("Youngest Friend: "+ names[youngestFrnd]);
		Console.WriteLine("Tallest Friend: "+ names[tallestFrnd]);
	}
}
		
		
		
		
	