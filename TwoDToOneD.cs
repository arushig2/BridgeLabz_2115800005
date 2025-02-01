using System;

class TwoDToOneD{
	static void Main(string[] args){
		//take input from user for rows and colums
		Console.Write("Enter a number of rows: ");
		int r = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a number of cols: ");
		int c = Convert.ToInt32(Console.ReadLine());
		
		int[,] matrix = new int[r, c];  //declare a 2-d matrix of size r X c
		int[] arr = new int[r * c]; //declare a array of size r * c
		
		for(int i = 0; i < r; i++){
			for(int j = 0; j < c; j++){
				Console.Write("Enter a number for cell (" + i + ", " + j + "): ");
				int n = Convert.ToInt32(Console.ReadLine()); //take input for each cell
				matrix[i, j] = n;
			}
		}
		
		int index = 0; //initialize index to 0
		
		for(int i = 0; i < r; i++){
			for(int j = 0; j < c; j++){
				arr[index] = matrix[i, j]; // assigne arr[index] to matrix[i][j]
				index++;
			}
		}		
				
		
		for(int i = 0; i < arr.Length; i++){
			Console.Write(arr[i] + " ");//display result
			
		}
		
		
	}
}