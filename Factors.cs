// using System;

// class Factors{
	// public static void Main(string[] args){
		// Console.Write("Enter a number: ");
		// int n = Convert.ToInt32(Console.ReadLine()); //take input from user
		
		// int maxIndex = 10; //initialize maxIndex
		// int[] factors = new int[maxIndex];  //declare array factors to store factors
		// int[] temp = new int[2 * maxIndex]; // declare a temp array of double size if needed
		// int index = 0; //initialize index 0
		
		// for(int i = 1; i <= n; i++){  //run a loop from 1 till n
			// if(n % i == 0){ //if a factor
				// if(maxIndex == 10){ //if we are storing in factors then maxIndex will be 10
					// factors[index] = i; //store in factors array
					// index++; //increment index
					
					// if(index == maxIndex){ //if we have reached the end of factor array
						// maxIndex *= 2; //double the maxIndex
					// }
				// } else { //we are storing in temp array
					// temp[index] = i;
					// index++;
				// }
			// }
		// }
		//print result
		// Console.Write("Factors are: ");
		// if(index < 10) { //if we have factors only in factors array
			// for(int i = 0; i < index; i++){ 
				// Console.Write(factors[i] + " ");
			// }
		// } else { //if we have used the temp array
			// for(int i = 0; i < 10; i++){  //copy factors array elements to temp
				// temp[i] = factors[i];
			// }
			//print result
			// for(int i = 0; i < index; i++){ 
				// Console.Write(temp[i] + " ");
			// }
		// }
	// }
// }
