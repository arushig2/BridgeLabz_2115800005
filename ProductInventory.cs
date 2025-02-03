using System;
public class Product
{
	private string productName; //instance variable
	private double price; //instance variable
	private static int totalProducts = 0; //class variable

	public string ProductName //getter setter
	{
		get { return productName; }
		set { productName = value; }
	}

	public double Price
	{
		get { return price; }
		set { price = value; }
	}

	public Product() 
	{
		totalProducts++; //increment total products as object is created
	}

	public Product(string productName, double price) //parametrized constructor
	{
		this.productName = productName;
		this.price = price;
       totalProducts++;
	}

   public void DisplayProductDetails() //instance method
	{
		Console.WriteLine($"Product name: {productName}");
		Console.WriteLine($"Price: {price}");
	}

	public static void DisplayTotalProducts() //class method
	{
		Console.WriteLine($"Total products in the inventory: {totalProducts}");
	}

}
class Program
{
	public static void Main(string[] args)
	{
		Product product1 = new Product("Chips", 20);
		product1.DisplayProductDetails();
		Product.DisplayTotalProducts();
		Product product2 = new Product("Tshirts", 200);
       product2.DisplayProductDetails();
       Product.DisplayTotalProducts();
       Product product3 = new Product("Bottles", 150);
       product3.DisplayProductDetails();
       Product.DisplayTotalProducts();
		Product product4 = new Product();
       Product.DisplayTotalProducts();

   }
}


