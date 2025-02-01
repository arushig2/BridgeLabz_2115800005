// using System;

// class YoungestAndTallest{
	// public static void Main(string[] args){
		
		// int[] age = new int[3]; //declare age array of size 3
		// int[] height = new int[3]; //declare height array of size 3
		// string[] names = {"Amar", "Akbar", "Anthony"}; //declare a name array to store name of friends
		
		// 0 - Amar 
		// 1 - Akbar
		// 2 - Anthony
		
		// for(int i = 0; i < age.Length; i++){ 
			// Console.WriteLine("Enter Age and Height of " + names[i]);
			// age[i] = Convert.ToInt32(Console.ReadLine()); //take input for age
			// height[i] = Convert.ToInt32(Console.ReadLine()); //take input for height
			
			// if(age[i] <= 0 || height[i] <= 0){ //in case of invalid age and height
				// Console.WriteLine("You entered a invalid age or a invalid height");
				// Environment.Exit(0);
			// }
		// }		
		
		// int youngestFrnd = -1, tallestFrnd = -1;
		// int minAge = int.MaxValue; //to store minimum age
		// int maxHeight = 0; //to store maximum height
		
		// for(int i = 0; i < age.Length; i++){
			// if(age[i] < minAge){ //if current age is less than minimum age
				// minAge = age[i]; 
				// youngestFrnd = i;
			// } 
			// if(height[i] > maxHeight){ //if current height is greater than maximum height
				// maxHeight = height[i];
				// tallestFrnd = i;
			// }
		// }
		
		// display result
		// Console.WriteLine("Youngest Friend: "+ names[youngestFrnd]);
		// Console.WriteLine("Tallest Friend: "+ names[tallestFrnd]);
	// }
// }
		
		
		
		
	