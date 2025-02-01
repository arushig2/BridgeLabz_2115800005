using System;

class NumberGuessingGame{
    static Random random = new Random();
   
    static int GenerateGuess(int low, int high){
        return random.Next(low, high + 1);
    }

    static char GetUserFeedback(){
        while (true){
            Console.Write("Is my guess (H)igh, (L)ow, or (C)orrect? ");
            char response = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (response == 'H' || response == 'L' || response == 'C')
                return response;
            Console.WriteLine("Invalid input. Please enter 'H' for high, 'L' for low, or 'C' for correct.");
        }
    }

    static void PlayGame(){
        Console.WriteLine("Think of a number between 1 and 100, and I will try to guess it!");
        int low = 1, high = 100;
        int guess;
        char feedback;

        do{
            guess = GenerateGuess(low, high);
            Console.WriteLine($"Guess is: {guess}");
            feedback = GetUserFeedback();

            if (feedback == 'H')
                high = guess - 1; // Reduce the upper bound
            else if (feedback == 'L')
                low = guess + 1; // Increase the lower bound

        }while (feedback != 'C');

        Console.WriteLine($"Guessed the number {guess} correctly!");
    }
	
    static void Main(){
        PlayGame();
    }
}
