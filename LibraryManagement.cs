using System;

public class Book
{
   private string title;
   private string author;
   private double price;
   private bool availability;

   public string Title //getter setter
   {
       get { return title; }
       set { title = value; }
   }

   public string Author
   {
       get { return author; }
       set { author = value; }
   }

   public double Price
   {
       get { return price; }
       set { price = value; }
   }

   public bool Availability
   {
       get { return availability; }
       set { availability = value; }
   }

   public Book() //default constructor
	{
	}

   public Book(string title,  string author, double price, bool availability) //parametrized constructor
   {
       this.title = title;
       this.author = author;
       this.price = price;
       this.availability = availability;
   }

   public void BorrowBook()
   {
       if (this.availability) //if availability is true
       {
           Console.WriteLine($"{title} by {author} priced {price} can be Borrowed!");
       }
       else //if availability is false
       {
           Console.WriteLine($"{title} by {author} priced {price} is not available");
       }
   }
}

public class Program
{
   public static void Main(string[] args)
   {
       Book book1 = new Book("Atomic Habits", "James Clear", 450, true);
       book1.BorrowBook();

       Book book2 = new Book("Cant Hurt Me", "David Goggins", 350, false);
       book2.BorrowBook();
   }
}

