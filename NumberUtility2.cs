using System;

class NumberChecker{
    
    public static int CountDigits(int number){
        int count = 0;
        while (number > 0){
            count++;
            number /= 10;
        }
        return count;
    }

    public static int[] GetDigits(int number){
        int count = CountDigits(number);
        int[] digits = new int[count];
        int index = count - 1;

        while (number > 0){
            digits[index--] = number % 10;
            number /= 10;
        }

        return digits;
    }

    public static int SumOfDigits(int number){
        int[] digits = GetDigits(number);
        int sum = 0;

        for (int i = 0; i < digits.Length; i++){
            sum += digits[i];
        }

        return sum;
    }

    public static double SumOfSquaresOfDigits(int number){
        int[] digits = GetDigits(number);
        double sum = 0;

        for (int i = 0; i < digits.Length; i++){
            sum += Math.Pow(digits[i], 2);
        }

        return sum;
    }

    public static bool IsHarshadNumber(int number){
        int sumOfDigits = SumOfDigits(number);
        return number % sumOfDigits == 0;
    }

    public static int[,] DigitFrequency(int number){
        int[] digits = GetDigits(number);
        int[,] frequency = new int[10, 2];

        //Initialize the frequency array
        for (int i = 0; i < 10; i++){
            frequency[i, 0] = i; // Store the digit
            frequency[i, 1] = 0; // Initialize frequency
        }

       //Count the frequency of each digit
        for (int i = 0; i < digits.Length; i++){
            frequency[digits[i], 1]++;
        }

        return frequency;
    }

    public static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

       //Display the count of digits
        Console.WriteLine("Count of digits: " + CountDigits(number));

       //Get digits array
        int[] digits = GetDigits(number);
        Console.WriteLine("Digits in the number: " + string.Join(", ", digits));

       //Display the sum of digits
        Console.WriteLine("Sum of digits: " + SumOfDigits(number));

       //Display the sum of the squares of digits
        Console.WriteLine("Sum of squares of digits: " + SumOfSquaresOfDigits(number));

       //Check if the number is a Harshad number
        Console.WriteLine("Is Harshad number: " + IsHarshadNumber(number));

        //display the frequency of each digit
        int[,] frequency = DigitFrequency(number);
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < 10; i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine("Digit " + frequency[i, 0] + ": " + frequency[i, 1]);
            }
        }
    }
}
