using System;

public class Employee{
	
	public string name;
	public int id;
	public double salary;
	
	public Employee(string name, int id, double salary){ //parametrized constructor to initialize values
		this.name = name;
		this.id = id;
		this.salary = salary;
	}
	
	public void DisplayDetails(){ //method to display details
		Console.WriteLine($"Name: {name}");
		Console.WriteLine($"ID: {id}");
		Console.WriteLine($"Salary: {salary}");
	}
}

public class Program{
	public static void Main(String[] args){
		Employee e1 = new Employee("Raj", 1, 100000); //create object of Employee class and initialize using constructor
		Employee e2 = new Employee("Suresh", 2, 50000);
		Employee e3 = new Employee("Richa", 3, 30000);
		
		Console.WriteLine("Employee 1");
		e1.DisplayDetails(); //call display details function 
		
		Console.WriteLine("Employee 2");
		e2.DisplayDetails();
		
		Console.WriteLine("Employee 3");
		e3.DisplayDetails();
	}
}
		