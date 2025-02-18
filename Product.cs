using System;
abstract class Category
{
    public string CategoryName { get; set; }
    public Category(string name)
    {
        CategoryName = name;
    }
}
class BookCategory : Category
{
    public BookCategory() : base("Books") { }
}
class ClothingCategory : Category
{
    public ClothingCategory() : base("Clothing") { }
}
abstract class BaseProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    protected BaseProduct(string name, double price)
    {
        Name = name;
        Price = price;
    }
    public abstract void Display();
}
class Product<TCategory> : BaseProduct where TCategory : Category
{
    public TCategory Category { get; set; }

    public Product(string name, double price, TCategory category)
        : base(name, price)
    {
        Category = category;
    }

    public override void Display()
    {
        Console.WriteLine($"{Category.CategoryName} - {Name}: {Price:F2}");
    }
}
static class DiscountManager
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : BaseProduct
    {
        if (percentage < 0 || percentage > 100)
        {
            throw new ArgumentException("Invalid discount percentage.");
        }
        product.Price -= product.Price * (percentage / 100);
    }
}
class Program
{
    static void Main()
    {
        var book = new Product<BookCategory>("C# Programming", 50, new BookCategory());
        var shirt = new Product<ClothingCategory>("T-Shirt", 20, new ClothingCategory());

        Console.WriteLine("Before Discount:");
        book.Display();
        shirt.Display();

        DiscountManager.ApplyDiscount(book, 10);
        DiscountManager.ApplyDiscount(shirt, 15);

        Console.WriteLine("\nAfter Discount:");
        book.Display();
        shirt.Display();
    }
}
