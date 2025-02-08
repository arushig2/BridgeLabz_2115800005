using System;

public class Vehicle
{
    public int maxSpeed;
    public string fuelType;

    public Vehicle(int maxSpeed, string fuelType)
    {
        this.maxSpeed = maxSpeed;
        this.fuelType = fuelType;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Max Speed: " + maxSpeed);
        Console.WriteLine("Fuel Type: " + fuelType);
    }
}

public class Car : Vehicle
{
    public int seatCapacity;
    public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
    {
        this.seatCapacity = seatCapacity;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine("Car Details: ");
        base.DisplayDetails();
        Console.WriteLine("Seat Capacity: " + seatCapacity);
    }
}

public class Truck : Vehicle
{
    public int payloadCapacity;
    public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
    {
        this.payloadCapacity = payloadCapacity;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine("Truck Details: ");
        base.DisplayDetails();
        Console.WriteLine("Payload Capacity: " + payloadCapacity);
    }
}

public class Motorcycle : Vehicle
{
    public Boolean hasSideCar;

    public Motorcycle(int maxSpeed, string fuelType, Boolean hasSideCar) : base(maxSpeed, fuelType)
    {
        this.hasSideCar = hasSideCar;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Motorcycle Details: ");
        base.DisplayDetails();
        Console.WriteLine("Has Side Car: " + hasSideCar);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(200, "Petrol", 5);

        vehicles[1] = new Truck(100, "Diesel", 1000);

        vehicles[2] = new Motorcycle(150, "Petrol", false);

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}