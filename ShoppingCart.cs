//using System;

//public class Product
//{
//    public static double discount = 10.0;
//    public string product;
//    public double price;
//    public int quantity;
//    public readonly int productId;


//    public Product()
//    {
       
//    }

//    public Product(string product, double price, int quantity, int productId)
//    {
//        this.product = product;
//        this.price = price;
//        this.quantity = quantity;
//        this.productId = productId;

//    }

//    public static void UpdateDiscount()
//    {
//        Console.WriteLine("Enter updated discount percentage: ");
//        discount = Convert.ToDouble(Console.ReadLine());    
//    }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Product Name: {product}");
//        Console.WriteLine($"Product ID: {productId}");
//        Console.WriteLine($"Quantity: {quantity}");
//        Console.WriteLine($"Discount Percentage: {discount}");
//        double newPrice = price - (price * discount / 100.0);
//        Console.WriteLine($"Discounted Price: {newPrice}");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        object obj1 = new Product("Iphone", 70000, 2, 12321);
//        object obj2 = new Product("Laptop", 65000, 4, 22442);
//        object obj3 = "Not an Product";

//        if (obj1 is Product prod1)
//        {
//            prod1.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj1 is not an instance of Product.");
//        }

//        Product.UpdateDiscount();

//        if (obj2 is Product prod2)
//        {
//            prod2.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj2 is not an instance of Product.");
//        }


//        if (obj3 is Product prod3)
//        {
//            prod3.DisplayDetails();
//        }
//        else
//        {
//            Console.WriteLine("obj3 is not an instance of Product.");
//        }

//    }
//}
