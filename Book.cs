using System;

public class Book
{
	private string title;
	private string author;
	private double price;

	public Book() //default constructor
	{
		title = "";
		author = "";
		price = 0;
	}

	public Book(string title, string author, double price) //parametrized constructor
	{
		this.title = title;
		this.author = author;
		this.price = price;
	}

	public void DisplayDetails()
	{
		Console.WriteLine($"Title: {title}");
		Console.WriteLine($"Author: {author}");
		Console.WriteLine($"Price: {price}");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Book book1 = new Book("Atomic Habits", "James Clear", 450);
		book1.DisplayDetails();

		Book book2 = new Book();
		book2.DisplayDetails();
	}
}
