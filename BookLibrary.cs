using System;

public class Book
{
   public long isbn;
   protected string title;
   private string author;

   public string GetAuthor()
   {
       return author;
   }

   public void SetAuthor(string authorName)
   {
       author = authorName;
   }

   public Book()
   {
   }

   public Book(long isbn, string title, string author)
   {
       this.isbn = isbn;
       this.title = title;
       this.author = author;
   }

   public void DisplayBookDetails()
   {
       Console.WriteLine("Book Details: ");
       Console.WriteLine($"ISBN: {isbn}");
       Console.WriteLine($"Title: {title}");
       Console.WriteLine($"Author: {author}");
   }
}

public class EBook : Book
{
   public string genre;

   public EBook(long isbn, string title, string author, string genre) : base(isbn, title, author)
   {
       this.genre = genre;
   }

   public void DisplayInfo()
   {
       Console.WriteLine("E-Book Details: ");
       DisplayBookDetails();
       Console.WriteLine($"Genre: {genre}");
   }

}

public class Program
{
   public static void Main(string[] args)
   {
       Book book = new Book(123457, "Book1", "John Doe");
       book.DisplayBookDetails();
       book.SetAuthor("John Doveee"); 
       book.DisplayBookDetails();

       Console.WriteLine($"Accessing Author name outside of class: {book.GetAuthor()}");

       EBook ebook = new EBook(234567, "E-Book1", "Mary Parker", "Horror"); //create object of subclass
       ebook.DisplayInfo(); //postgraduate method
       ebook.SetAuthor("Karen Green"); //set cgpa using function of student class
       ebook.DisplayBookDetails(); //object of subclass call method of base class
       Console.WriteLine($"Accessing Author name outside of class: {ebook.GetAuthor()}");
   }
}
