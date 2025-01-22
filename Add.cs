using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        int number2 = Console.ReadLine();

        int sum = number1 + number2;

        Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + sum);
    }
}