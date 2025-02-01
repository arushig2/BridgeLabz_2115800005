using System;

class NumberChecker{
    public static int[] FindFactors(int number){
        int count = 0;

        // First loop to count how many factors there are
        for (int i = 1; i <= number; i++){
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    public static int FindGreatestFactor(int[] factors){
        return factors[factors.Length - 1];
    }

    public static int SumOfFactors(int[] factors){
        int sum = 0;
        for (int i = 0; i < factors.Length; i++){
            sum += factors[i];
        }
        return sum;
    }

    public static int ProductOfFactors(int[] factors){
        int product = 1;
        for (int i = 0; i < factors.Length; i++){
            product *= factors[i];
        }
        return product;
    }

  
    public static double ProductOfCubeOfFactors(int[] factors){
        double product = 1;
        for (int i = 0; i < factors.Length; i++){
            product *= Math.Pow(factors[i], 3);
        }
        return product;
    }

    public static bool IsPerfectNumber(int number) {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // exclude the number itself
        return sum == number;
    }
 
    public static bool IsAbundantNumber(int number){
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // exclude the number itself
        return sum > number;
    }

    public static bool IsDeficientNumber(int number){
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // exclude the number itself
        return sum < number;
    }

    public static bool IsStrongNumber(int number){
        int originalNumber = number;
        int sum = 0;

        while (number > 0){
            int digit = number % 10;
            sum += Factorial(digit);
            number /= 10;
        }

        return sum == originalNumber;
    }

    
    public static int Factorial(int n){
        int result = 1;
        for (int i = 1; i <= n; i++){
            result *= i;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find the factors of the number
        int[] factors = FindFactors(number);

        // Find the greatest factor
        int greatestFactor = FindGreatestFactor(factors);

        // Find the sum of the factors
        int sumOfFactors = SumOfFactors(factors);

        // Find the product of the factors
        int productOfFactors = ProductOfFactors(factors);

        // Find the product of the cube of the factors
        double productOfCubes = ProductOfCubeOfFactors(factors);

        // Check if the number is a perfect number
        bool isPerfect = IsPerfectNumber(number);

        // Check if the number is an abundant number
        bool isAbundant = IsAbundantNumber(number);

        // Check if the number is a deficient number
        bool isDeficient = IsDeficientNumber(number);

        // Check if the number is a strong number
        bool isStrong = IsStrongNumber(number);

        // Display results
        Console.WriteLine("Factors of " + number + ": " + string.Join(", ", factors));
        Console.WriteLine("Greatest factor: " + greatestFactor);
        Console.WriteLine("Sum of factors: " + sumOfFactors);
        Console.WriteLine("Product of factors: " + productOfFactors);
        Console.WriteLine("Product of cubes of factors: " + productOfCubes);
        Console.WriteLine("Is " + number + " a perfect number? " + isPerfect);
        Console.WriteLine("Is " + number + " an abundant number? " + isAbundant);
        Console.WriteLine("Is " + number + " a deficient number? " + isDeficient);
        Console.WriteLine("Is " + number + " a strong number? " + isStrong);
    }
}
