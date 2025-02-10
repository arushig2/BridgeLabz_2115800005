using System;
using System.Security.Permissions;

public abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;

    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }

    public abstract void GetLoanDuration();
}

public interface IReservable
{
    public void ReserveItem();
    public bool CheckAvailability();
}

public class Book : LibraryItem, IReservable
{
    private string borrowerName;
    private int borrowerId;
    private static int units = 5;

    public string name
    {
        get { return borrowerName; }
        set { borrowerName = value; }
    }

    public int id
    {
        get { return borrowerId; }
        set { borrowerId = value; }
    }

    public Book(int itemId, string title, string author, string name, int id) : base(itemId, title, author)
    {
        this.name = name;
        this.id = id;
    }

    public override void GetLoanDuration()
    {
        Console.WriteLine("No. of days to rent");
        int n = Convert.ToInt16(Console.ReadLine());

        if (n > 14)
        {
            Console.WriteLine("You can rent this book for 14 days only");
        }
        else
        {
            Console.WriteLine("You can rent this book for " + n + " days");
        }
    }

    public void ReserveItem()
    {
        if (CheckAvailability())
        {
            Console.WriteLine("Item reserved successfully");
            units--;
        }
        else
        {
            Console.WriteLine("Item not available for reservation");
        }

    }

    public bool CheckAvailability()
    {
        if (units > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class DVD : LibraryItem, IReservable
{
    private string borrowerName;
    private int borrowerId;
    private static int units = 12;

    public string name
    {
        get { return borrowerName; }
        set { borrowerName = value; }
    }

    public int id
    {
        get { return borrowerId; }
        set { borrowerId = value; }
    }

    public DVD(int itemId, string title, string author, string name, int id) : base(itemId, title, author)
    {
        this.name = name;
        this.id = id;
    }

    public override void GetLoanDuration()
    {
        Console.WriteLine("No. of days to rent");
        int n = Convert.ToInt16(Console.ReadLine());

        if (n > 7)
        {
            Console.WriteLine("You can rent this DVD for 7 days only");
        }
        else
        {
            Console.WriteLine("You can rent this DVD for " + n + " days");
        }
    }

    public void ReserveItem()
    {
        if (CheckAvailability())
        {
            Console.WriteLine("Item reserved successfully");
            units--;
        }
        else
        {
            Console.WriteLine("Item not available for reservation");
        }

    }

    public bool CheckAvailability()
    {
        if (units > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Magazine : LibraryItem, IReservable
{
    private string borrowerName;
    private int borrowerId;
    private static int units = 10;

    public string name
    {
        get { return borrowerName; }
        set { borrowerName = value; }
    }

    public int id
    {
        get { return borrowerId; }
        set { borrowerId = value; }
    }

    public Magazine(int itemId, string title, string author, string name, int id) : base(itemId, title, author)
    {
        this.name = name;
        this.id = id;
    }

    public override void GetLoanDuration()
    {
        Console.WriteLine("No. of days to rent");
        int n = Convert.ToInt16(Console.ReadLine());

        if (n > 2)
        {
            Console.WriteLine("You can rent this Magazine for 2 days only");
        }
        else
        {
            Console.WriteLine("You can rent this Magazine for " + n + " days");
        }
    }

    public void ReserveItem()
    {
        if (CheckAvailability())
        {
            Console.WriteLine("Item reserved successfully");
            units--;
        }
        else
        {
            Console.WriteLine("Item not available for reservation");
        }

    }

    public bool CheckAvailability()
    {
        if (units > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}


public class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book(123, "Atomic Habits", "James Clear", "Arvind", 23);
        book.ReserveItem();
        book.GetLoanDuration();

        DVD dvd = new DVD(234, "Love Tour", "Mary Jane", "Maya", 33);
        dvd.ReserveItem();
        dvd.GetLoanDuration();

        Magazine magazine = new Magazine(345, "National Geographic", "John Doe", "Raj", 43);
        magazine.ReserveItem();
        magazine.GetLoanDuration();


    }
}

