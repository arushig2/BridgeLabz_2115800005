using System;

public class Circle
{
	private double radius;

	public Circle(): this(0.0) { } //Default constructor, constructor chaining using :this()
	
	public Circle(double radius) //parametrized constructor
	{
		this.radius = radius;
	}

	public void DisplayDetails()
	{
		Console.WriteLine($"Radius: {radius}");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Circle circle1 = new Circle();
		Circle circle2 = new Circle(2.0);

		circle1.DisplayDetails(); //0
		circle2.DisplayDetails(); //2
	}
}



