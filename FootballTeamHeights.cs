using System;

class FootballTeamHeights{
	
		public static int[] GenerateHeights(){
        int[] heights = new int[11];
        Random rand = new Random();

        for (int i = 0; i < heights.Length; i++){
            heights[i] = rand.Next(150, 251); // Generate random heights in the range 150-250 cm
        }

        return heights;
    }
	
	public static int CalculateSum(int[] heights){
        int sum = 0;

        for (int i = 0; i < heights.Length; i++){
			sum += heights[i];
        }

        return sum;
    }
	
	public static double CalculateMean(int[] heights){
        int sum = CalculateSum(heights);
        return (double)sum / heights.Length;
    }
	
	public static int FindShortest(int[] heights){
        int shortest = int.MaxValue;

          for (int i = 0; i < heights.Length; i++){
            if (heights[i] < shortest){
                shortest = heights[i];
            }
        }

        return shortest;
    }
	
	public static int FindTallest(int[] heights){
        int tallest = int.MinValue;

          for (int i = 0; i < heights.Length; i++){
            if (heights[i] > tallest){
                tallest = heights[i];
            }
        }

        return tallest;
    }
	 public static void Main(string[] args){
    
        int[] heights = GenerateHeights();

        //Calculate the results
        double mean = CalculateMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        // Display the heights
        Console.WriteLine("Heights of players in the football team (in cms): ");
        for(int i = 0; i < heights.Length; i++)
        {
            Console.Write(heights[i] + " ");
        }
        Console.WriteLine();

        Display the results
        Console.WriteLine("Mean height: " + mean);
        Console.WriteLine("Shortest height: " + shortest);
        Console.WriteLine("Tallest height: " + tallest);
    }
}