using System;
using System.Collections.Generic;

public class Book
{
	public string title;
	public string author;

	public Book()
	{
	}

	public Book(string title, string author)
	{
		this.title = title;
		this.author = author;
	}
}

public class Library
{
	List<Book> books;

	public Library()
	{
		books = new List<Book>();
	}

	public void AddBook(Book book)
	{
		books.Add(book);
		Console.WriteLine($"{book.title} added to library");
	}

	public void DisplayBook()
	{
		foreach (Book book in books)
		{
			Console.WriteLine($"{book.title} by {book.author}");
		}
	}

	public void RemoveBook(Book book)
	{
		books.Remove(book);
		Console.WriteLine($"{book.title} removed from library");
	}
}

class Program
{
	public static void Main(string[] args)
	{
		Library library1 = new Library();
		Library library2 = new Library();
		Book book1 = new Book("atomic habits", "james clear");
		Book book2 = new Book("Cant Hurt Me", "david goggings");
		Book book3 = new Book("harry potter", "JK Rowling");
		Book book4 = new Book("the merchant of venice", "Shakespeare");
		library1.AddBook(book1);
		library2.AddBook(book2);
		library1.AddBook(book3);
		library1.AddBook(book4);

		Console.WriteLine();
		Console.WriteLine("books in library 1");
		library1.DisplayBook();
		Console.WriteLine();
		Console.WriteLine("books in library 2");
		library2.DisplayBook();
		Console.WriteLine();
		library1.RemoveBook(book1);
		library2.RemoveBook(book2);
	}
}