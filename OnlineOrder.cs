using System;

public class Order
{
    public int orderId;
    public DateTime orderDate;

    public Order(int orderId, DateTime orderDate)
    {
        this.orderId = orderId;
        this.orderDate = orderDate;
    }

    public void GetOrderStatus()
    {
        Console.WriteLine("Order ID: " + orderId);
        Console.WriteLine("Order Date: " + orderDate);
    }
}

public class ShippedOrder : Order
{
    public int trackingNumber;

    public ShippedOrder(int orderId, DateTime orderDate, int trackingNumber) : base(orderId, orderDate)
    {
        this.trackingNumber = trackingNumber;
    }

    public void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Tracking Number: " + trackingNumber);
    }

}

public class DeliveredOrder : ShippedOrder
{
    public DateTime deliveryDate;
    public DeliveredOrder(int orderId, DateTime orderDate, int trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
    {
        this.deliveryDate = deliveryDate;
    }
    public void GetOrderStatus()
    {
        base.GetOrderStatus();
        Console.WriteLine("Delivery Date: " + deliveryDate);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Order order = new Order(1, new DateTime(2021, 10, 10));
        order.GetOrderStatus();

        Console.WriteLine();

        ShippedOrder shippedOrder = new ShippedOrder(2, new DateTime(2021, 10, 11), 12345);
        shippedOrder.GetOrderStatus();

        Console.WriteLine();

        DeliveredOrder deliveredOrder = new DeliveredOrder(3, new DateTime(2021, 10, 12), 12346, new DateTime(2021, 10, 13));
        deliveredOrder.GetOrderStatus();
    }
}
