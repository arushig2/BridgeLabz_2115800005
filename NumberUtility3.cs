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

  
    public static int[] ReverseDigits(int[] digits){
        int[] reversedDigits = new int[digits.Length];
        int index = 0;

        for (int i = digits.Length - 1; i >= 0; i--){
            reversedDigits[index++] = digits[i];
        }

        return reversedDigits;
    }

   
    public static bool CompareArrays(int[] array1, int[] array2){
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++){
            if (array1[i] != array2[i])
                return false;
        }

        return true;
    }

   
    public static bool IsPalindrome(int number){
        int[] digits = GetDigits(number);
        int[] reversedDigits = ReverseDigits(digits);

        return CompareArrays(digits, reversedDigits);
    }

   
    public static bool IsDuckNumber(int number){
        int[] digits = GetDigits(number);

        for (int i = 1; i < digits.Length; i++){
            if (digits[i] != 0){
                return true;
            }
        }

        return false;
    }

    public static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Display the count of digits
        Console.WriteLine("Count of digits: " + CountDigits(number));

    //    Get digits array
        int[] digits = GetDigits(number);
        Console.WriteLine("Digits in the number: " + string.Join(", ", digits));

    //    Reverse the digits and display
        int[] reversedDigits = ReverseDigits(digits);
        Console.WriteLine("Reversed digits: " + string.Join(", ", reversedDigits));

    //    Check if the number is a palindrome
        Console.WriteLine("Is palindrome: " + IsPalindrome(number));

    //    Check if the number is a duck number
        Console.WriteLine("Is duck number: " + IsDuckNumber(number));
    }
}
