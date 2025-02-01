using System;

class OTPGenerator{
  
    public static int GenerateOTP(){
        Random random = new Random();
        return random.Next(100000, 1000000); // Generates a 6-digit OTP 
    }

   
    public static bool AreUnique(int[] otpNumbers){
        for (int i = 0; i < otpNumbers.Length; i++){
            for (int j = i + 1; j < otpNumbers.Length; j++){
                if (otpNumbers[i] == otpNumbers[j]){
                    return false; // If any OTP is repeated, return false
                }
            }
        }
        return true; // All OTPs are unique
    }

    static void Main(string[] args){
        
        int[] otpNumbers = new int[10];
   
        for (int i = 0; i < otpNumbers.Length; i++){
            otpNumbers[i] = GenerateOTP();
        }

        // Display the OTP 
        Console.WriteLine("Generated OTPs:");
        for (int i = 0; i < otpNumbers.Length; i++){
            Console.WriteLine(otpNumbers[i]);
        }

        if (AreUnique(otpNumbers)){
            Console.WriteLine("All OTP numbers are unique.");
        } else {
            Console.WriteLine("Some OTP numbers are repeated.");
        }
    }
}
