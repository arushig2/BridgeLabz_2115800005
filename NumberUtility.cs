using System;

class NumberChecker
{
   
    public static int CountDigits(int number){
        int count = 0;
        while (number > 0){
            count++; //count the digits
            number /= 10;
        }
        return count;
    }

    
    public static int[] GetDigits(int number){
        int count = CountDigits(number);
        int[] digits = new int[count];
        int index = count - 1;

        while (number > 0){
            digits[index--] = number % 10; //store the digits in the aray
            number /= 10;
        }

        return digits;
    }

   
    public static bool IsDuckNumber(int number){
        int[] digits = GetDigits(number);
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] == 0) return true; //if number contains zero it is duck number
        }
        return false;
    }

    public static bool IsArmstrongNumber(int number){
        int[] digits = GetDigits(number);
        int power = digits.Length;
        int sum = 0;

        for (int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], power);
        }

        return sum == number;
    }

		  
		   Method to find the largest and second largest digits
		public static int[] FindLargestAndSecondLargest(int[] digits){
			int largest = int.MinValue;
			int secondLargest = int.MinValue;

			for (int i = 0; i < digits.Length; i++){
				if (digits[i] > largest){
					secondLargest = largest;
					largest = digits[i];
				}  else if (digits[i] > secondLargest && digits[i] < largest){
					secondLargest = digits[i];
				}
			}

			return new int[] { largest, secondLargest };
		}

		Method to find the smallest and second smallest digits
		public static int[] FindSmallestAndSecondSmallest(int[] digits){
			int smallest = int.MaxValue;
			int secondSmallest = int.MaxValue;

			for (int i = 0; i < digits.Length; i++){
				if (digits[i] < smallest){
					secondSmallest = smallest;
					smallest = digits[i];
				} else if (digits[i] < secondSmallest && digits[i] > smallest){
					secondSmallest = digits[i];
				}
			}

			return new int[] { smallest, secondSmallest };
		}

    public static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Display digit count
        Console.WriteLine("Number of digits: " + CountDigits(number));

       Get digits array
        int[] digits = GetDigits(number);
        Console.WriteLine("Digits in the number: " + string.Join(", ", digits));

       Check if the number is a Duck number
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(number));

       Check if the number is an Armstrong number
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number));

		Find and display the largest and second largest digits
		int[] largestDigits = FindLargestAndSecondLargest(digits);
		Console.WriteLine("Largest digit: " + largestDigits[0]);
		Console.WriteLine("Second largest digit: " + largestDigits[1]);

		Find and display the smallest and second smallest digits
		int[] smallestDigits = FindSmallestAndSecondSmallest(digits);
		Console.WriteLine("Smallest digit: " + smallestDigits[0]);
		Console.WriteLine("Second smallest digit: " + smallestDigits[1]);

    }
}
