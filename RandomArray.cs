using System;

class RandomArray{
	
	public static int[] Generate4DigitRandomArray(int size){
		int[] arr = new int[5];
		
		Random rand = new Random();
		 
		for(int i = 0; i < size; i++){
			arr[i] = rand.Next(1000, 10000);
		}
		
		return arr;
		
	}
	
	public static double[] FindAverageMinMax(int[] numbers){
		 double[] ans = new double[3];
		 
		 double avg = 0;
		 double min = 100000;
		 double max = 999;
		 
		 for(int i = 0; i < numbers.Length; i++){
			 avg += numbers[i];
			 
			 if(numbers[i] < min) min = numbers[i];
			 
			 if(numbers[i] > max) max = numbers[i];
		 }
		 
		 avg /= numbers.Length;
		 
		 ans[0] = avg;
		 ans[1] = min;
		 ans[2] = max;
		 
		 return ans;
	}

		
	static void Main(string[] args){
		int size = 5;
		
		int[] arr = Generate4DigitRandomArray(5);
		double[] ans = FindAverageMinMax(arr);	
		
		Console.WriteLine("Array: ");
		for(int i = 0; i < size; i++){
			Console.Write(arr[i] + " ");
		}
		
		Console.WriteLine("\nAvergae: " + ans[0]);
		Console.WriteLine("Minimum: " + ans[1]);
		Console.WriteLine("Maximum: " + ans[2]);
	
	}
}
		