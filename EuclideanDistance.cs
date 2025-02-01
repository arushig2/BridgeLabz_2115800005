using System;

class EuclideanDistance{
    public static double CalculateDistance(double x1, double y1, double x2, double y2){
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to find the equation of a line passing through two points
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2){
        double[] equation = new double[2]; 

        if (x2 != x1){
            // Calculate slope (m)
            double m = (y2 - y1) / (x2 - x1);

            // Calculate y-intercept (b)
            double b = y1 - m * x1;

            equation[0] = m;
            equation[1] = b;
        } else {
            Console.WriteLine("The line is vertical (undefined slope).");
            equation[0] = double.NaN; // Slope is undefined for a vertical line
            equation[1] = double.NaN;
        }

        return equation;
    }

    static void Main(string[] args){
        // Input coordinates of the two points
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate the Euclidean distance
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance: " + distance);

        // Find the equation of the line
        double[] equation = FindLineEquation(x1, y1, x2, y2);
        if (!double.IsNaN(equation[0]))
        {
            Console.WriteLine("Equation of the line: y = " + equation[0] + "x + " + equation[1]);
        }
    }
}
