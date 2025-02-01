using System;

class YoungestAndTallest{
	public static int Youngest(int[] age){
		int minAge = int.MaxValue;
		int youngestFrnd = -1;
		for(int i = 0; i < age.Length; i++){
			if(age[i] < minAge){
				minAge = age[i];
				youngestFrnd = i;
			} 
		}
		
		return youngestFrnd;
	}
	
	public static int Tallest(int[] height){
		int maxHeight = 0;
		int tallestFrnd = -1;
		for(int i = 0; i < height.Length; i++){
			if(height[i] > maxHeight){
				maxHeight = height[i];
				tallestFrnd = i;
			}
		}
			
		return tallestFrnd;
	}
	public static void Main(string[] args){
		
		int[] age = new int[3]; 
		int[] height = new int[3]; 
		string[] names = {"Amar", "Akbar", "Anthony"};
		
		// 0 - Amar 
		// 1 - Akbar
		// 2 - Anthony
		
		for(int i = 0; i < age.Length; i++){ 
			Console.WriteLine("Enter Age and Height of " + names[i]);
			age[i] = Convert.ToInt32(Console.ReadLine());
			height[i] = Convert.ToInt32(Console.ReadLine());
			
			if(age[i] <= 0 || height[i] <= 0){
				Console.WriteLine("You entered a invalid number");
				Environment.Exit(0);
			}
		}		
		
		int youngestFrnd = Youngest(age);
		int tallestFrnd = Tallest(height);
		
		Console.WriteLine("Youngest Friend: "+ names[youngestFrnd]);
		Console.WriteLine("Tallest Friend: "+ names[tallestFrnd]);
	}
}
		
		
		
		
	