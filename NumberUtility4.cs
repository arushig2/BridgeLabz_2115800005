using System;

class NumberChecker{
    
    public static bool IsPrime(int number) {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public static bool IsNeon(int number){
        int square = number * number;
        int sumOfDigits = 0;

       Sum the digits of the square
        while (square > 0){
            sumOfDigits += square % 10;
            square /= 10;
        }

        return sumOfDigits == number;
    }

    public static bool IsSpy(int number){
        int sum = 0;
        int product = 1;
        while (number > 0){
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

   
    public static bool IsAutomorphic(int number){
        int square = number * number;
        string numStr = number.ToString();
        string squareStr = square.ToString();

        return squareStr.EndsWith(numStr);
    }

   public static bool IsBuzz(int number){
        return number % 7 == 0 || number % 10 == 7;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is prime
        Console.WriteLine("Is " + number + " a prime number? " + IsPrime(number));

        // Check if the number is a neon number
        Console.WriteLine("Is " + number + " a neon number? " + IsNeon(number));

        // Check if the number is a spy number
        Console.WriteLine("Is " + number + " a spy number? " + IsSpy(number));

        // Check if the number is an automorphic number
        Console.WriteLine("Is " + number + " an automorphic number? " + IsAutomorphic(number));

        // Check if the number is a buzz number
        Console.WriteLine("Is " + number + " a buzz number? " + IsBuzz(number));
    }
}
