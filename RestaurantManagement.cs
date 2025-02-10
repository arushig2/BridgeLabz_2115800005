using System;
using System.Collections.Generic;

abstract class FoodItem
{
    public string ItemName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public FoodItem(string itemName, double price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine($"Item: {ItemName}, Price: {Price}, Quantity: {Quantity}");
    }
}
interface IDiscountable
{
    double ApplyDiscount(double percentage);
    string GetDiscountDetails();
}

class VegItem : FoodItem, IDiscountable
{
    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    public double ApplyDiscount(double percentage)
    {
        return CalculateTotalPrice() * (1 - percentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Veg items get a 10% discount.";
    }
}


class NonVegItem : FoodItem, IDiscountable
{
    private const double ExtraCharge = 20;

    public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) + ExtraCharge;
    }

    public double ApplyDiscount(double percentage)
    {
        return CalculateTotalPrice() * (1 - percentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Non-veg items get a 5% discount.";
    }
}

class Program
{
    static void Main()
    {
        List<FoodItem> foodItems = new List<FoodItem>
        {
            new VegItem("Paneer Tikka", 200, 2),
            new NonVegItem("Chicken Biryani", 300, 1)
        };

        foreach (var item in foodItems)
        {
            item.GetItemDetails();
            Console.WriteLine($"Total Price: {item.CalculateTotalPrice()}");

            if (item is IDiscountable discountableItem)
            {
                Console.WriteLine(discountableItem.GetDiscountDetails());
                Console.WriteLine($"Price after Discount: {discountableItem.ApplyDiscount(item is VegItem ? 10 : 5)}");
            }
            Console.WriteLine();
        }
    }
}
