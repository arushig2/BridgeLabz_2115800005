using System;

class MaxDigitIndex {
    static void Main(string[] args) {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigits = 10; 
        int[] digits = new int[maxDigits]; 
        int index = 0; // Index to track the position in the array
    
        while (number != 0) {
            // If index reaches maxDigits, increase the size 
            if (index == maxDigits) {
                maxDigits += 10; // Increase size by 10
                int[] temp = new int[maxDigits]; // Create a new array with increased size
                Array.Copy(digits, temp, digits.Length); // Copy the old array elements 
                digits = temp; // Assign the temp array back to digits
            }
			
            digits[index] = number % 10;
            number = number / 10;
            index++;
        }

        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++) {
            if (digits[i] > largest) {
                secondLargest = largest; // Update second largest
                largest = digits[i]; // Update largest
            } else if (digits[i] > secondLargest && digits[i] < largest) {
                secondLargest = digits[i]; // Update second largest
            }
        }

        // Display the result
        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }
}
