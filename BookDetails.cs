using System;

public class Book{
	
	public string title;
	public string author;
	public double price;
	
	public Book(){ //parametrized constructor to initialize values
		title = "";
		author = "";
		price = 0;
	}
	
	public Book(string title, string author, double price){ //parametrized constructor to initialize values
		this.title = title;
		this.author = author;
		this.price = price;
	}
	
	public void DisplayDetails(){ //method to display details
		Console.WriteLine($"Title: {title}");
		Console.WriteLine($"Author: {author}");
		Console.WriteLine($"Price: {price}");
	}
}

public class Program{
	public static void Main(String[] args){
		Book b1 = new Book("Atomic Habits", "James Clear", 450); //create object of Book class and initialize using constructor
		Book b2 = new Book("Can't Hurt Me", "David Goggins", 300);
		Book b3 = new Book("Harry Potter", "Ruskin Bond", 1000);
				
		Console.WriteLine("Book 1");
		b1.DisplayDetails(); //call display details function 
		
		Console.WriteLine("Book 2");
		b2.DisplayDetails();
		
		Console.WriteLine("Book 3");
		b3.DisplayDetails();
	}
}
		