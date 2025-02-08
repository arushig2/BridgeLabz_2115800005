using System;
using System.Security.Cryptography.X509Certificates;

public class Book
{
    public string title;
    public int publicationYear;

    public Book(string title, int publicationYear)
    {
        this.title = title;
        this.publicationYear = publicationYear;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Publication Year: " + publicationYear);
    }
}

public class Author : Book
{
    public string name;
    public string bio;

    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
    {
        this.name = name;
        this.bio = bio;
    }
    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Author Name: " + name);
        Console.WriteLine("Author Bio: " + bio);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book("The Alchemist", 1988);
        book.DisplayDetails();
        Console.WriteLine();
        Author author = new Author("The Alchemist", 1988, "Paulo Coelho", "Paulo Coelho is a Brazilian lyricist and novelist.");
        author.DisplayDetails();
    }
}
