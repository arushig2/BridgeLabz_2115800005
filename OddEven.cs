// using System;

// class OddEven{
	// public static void Main(string[] args){
		// Console.Write("Enter a number: ");
		// int n = Convert.ToInt32(Console.ReadLine()); //take input from user
		
		// int size = (n / 2) + 1; //calculate the expected size of ther array
		// int[] odd = new int[size]; //create a array for odd numbers of size
		// int[] even = new int[size]; //create a array for odd numbers of size
		
		// int oddIndex = 0, evenIndex = 0; //initialize odd index and even index to determine the next empty index
	
		// for(int i = 1; i <= n; i++){ 
			// if(i % 2 == 0){ //if even
				// even[evenIndex] = i; //store value in even array
				// evenIndex++; //increment evenIndex
			// } else { //if odd
				// odd[oddIndex] = i; //store value in odd index
				// oddIndex++; //increment oddIndex
			// }
		// }
		
		// Console.Write("Odd numbers array: \n"); //Display the elements of odd array
		// for(int i = 0; i < oddIndex; i++){ 
			// Console.WriteLine(odd[i]);
		// }
	
		// Console.Write("Even numbers array: \n"); //Display the elements of even array
		// for(int i = 0; i < evenIndex; i++){ 
			// Console.WriteLine(even[i]);
		// }
	// }
// }
