using System;

public class Circle{
	
	public double radius;
	public double pi = 3.14;
	
	public Circle(double radius){ //parametrized constructor to initialize values
		this.radius = radius;
	}
	
	public double Circumference(){ 	//function to calculate circumference
		double circum = 2 * pi * radius;
		return circum;
		
	}
	
	public double Area(){ 	//function to calculate area 
		double area = pi * radius * radius;
		return area;
	}
	
	public void DisplayDetails(){ //function to display the details
		double circum = Circumference();
		double area = Area();
		Console.WriteLine($"Radius = {radius}");
		Console.WriteLine($"Circumference = {circum}");
		Console.WriteLine($"Area = {area}");
	}
}

public class Program{
	public static void Main(String[] args){
		Circle c1 = new Circle(3.0); //create object of circle class and initialize using constructor
		Circle c2 = new Circle(4.5);
		Circle c3 = new Circle(3.75);
		
		Console.WriteLine("First Circle");
		c1.DisplayDetails(); //call display details function 
		
		Console.WriteLine("Second Circle");
		c2.DisplayDetails();
		
		Console.WriteLine("Third Circle");
		c3.DisplayDetails();
	}
}
		