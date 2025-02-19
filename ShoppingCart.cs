using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>(); 
    private LinkedList<KeyValuePair<string, double>> cartOrder = new LinkedList<KeyValuePair<string, double>>(); 
    private SortedDictionary<double, List<string>> sortedCart = new SortedDictionary<double, List<string>>(); 
    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
            cartOrder.AddLast(new KeyValuePair<string, double>(product, price));

            if (!sortedCart.ContainsKey(price))
            {
                sortedCart[price] = new List<string>();
            }
            sortedCart[price].Add(product);
        }
        else
        {
            Console.WriteLine($"Product '{product}' is already in the cart!");
        }
    }

    public void DisplayCartOrder()
    {
        Console.WriteLine("\nCart Order:");
        foreach (var item in cartOrder)
        {
            Console.WriteLine($"{item.Key}: ${item.Value}");
        }
    }

    public void DisplayProductPrices()
    {
        Console.WriteLine("\nProduct Prices:");
        foreach (var kvp in productPrices)
        {
            Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
        }
    }

    public void DisplaySortedByPrice()
    {
        Console.WriteLine("\nCart Sorted by Price:");
        foreach (var kvp in sortedCart)
        {
            foreach (var product in kvp.Value)
            {
                Console.WriteLine($"{product}: ${kvp.Key}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.AddProduct("Laptop", 999.99);
        cart.AddProduct("Phone", 599.49);
        cart.AddProduct("Headphones", 99.99);
        cart.AddProduct("Keyboard", 49.99);
        cart.AddProduct("Mouse", 29.99);

        cart.DisplayCartOrder();     
        cart.DisplayProductPrices();  
        cart.DisplaySortedByPrice();  
    }
}
