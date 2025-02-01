// using System;

// class LargestSecondLargest {
    // static void Main(string[] args) {
        //take user input for the number
        // Console.Write("Enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // int maxDigits = 10; // Set the maximum size of the array
        // int[] digits = new int[maxDigits]; 
        // int index = 0; // Index to track the position

       // Extract digits and store them in the array
        // while (number != 0) {
           // Get the last digit
            // digits[index] = number % 10;
            // number = number / 10; 
            // index++;

            // if (index == maxDigits) { //if index equals to maxDigits
                // break;
            // }
        // }

        // int largest = 0;
        // int secondLargest = 0;

        // for (int i = 0; i < index; i++) {
            // if (digits[i] > largest) {
                // secondLargest = largest; // Update second largest
                // largest = digits[i]; // Update largest
            // } else if (digits[i] > secondLargest && digits[i] < largest) {
                // secondLargest = digits[i]; // Update second largest
            // }
        // }

        //Display the result
        // Console.WriteLine("Largest Digit: " + largest);
        // Console.WriteLine("Second Largest Digit: " + secondLargest);
    // }
// }
