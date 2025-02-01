using System;

class QuadraticEquation{
	
	static double[] FindRoots(double a, double b, double c){
		
		double delta = Math.Pow(b, 2) - (4 * a * c);
		
		if(delta > 0){
			double[] roots = new double[2];
			
			roots[0] =  (-b + Math.Sqrt(delta)) / (2 * a);
			roots[1] = (-b - Math.Sqrt(delta)) / (2 * a);
			
			return roots;
		} else if (delta == 0){
			double[] roots = new double[1];
			
			roots[0] = -b / (2 * a);
			
			return roots;
		} 
		
		return new double[0];
	 
	}
		
	static void Main(string[] args){
		Console.Write("Enter value of a: ");
		double a = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter value of b: ");
		double b = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter value of c: ");
		double c = Convert.ToDouble(Console.ReadLine());
		
		double[] roots = FindRoots(a, b, c);
		
		Console.WriteLine("Roots are: ");
		
		for(int i = 0; i < roots.Length; i++){
			
			Console.Write(roots[i] + " ");
		
		}
	
	}
}
		