using System;

class GcdLcm{
	static int GetInput(){
		Console.WriteLine("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine()); //take input from user
		return num;
	}
	
    static int GCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b){
        return Math.Abs(a * b) / GCD(a, b); // LCM formula: (a * b) / GCD(a, b)
    }

    static void Output(int gcd, int lcm){
        Console.WriteLine($"GCD: {gcd}");
        Console.WriteLine($"LCM: {lcm}");
    }

    static void Main(){
        int a = GetInput(); 
		int b = GetInput();
        int gcd = GCD(a, b); // Calculate GCD
        int lcm = LCM(a, b); // Calculate LCM
        Output(gcd, lcm); // Display the results
    }
}
