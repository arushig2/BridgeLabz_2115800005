using System;
using System.Collections.Generic;

public interface IInsurable
{
    public double CalculateInsurance();
    public void GetInsuranceDetails();
}

public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }
    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);
}

public class Car : Vehicle, IInsurable
{
    private string insuranceNumber;

    public string InsuranceNumber
    {
        get { return insuranceNumber; }
        set { insuranceNumber = value; }
    }
    public Car(string vehicleNumber, string type, double rentalRate, string insuranceNumber) : base(vehicleNumber, "Car", rentalRate)
    {
        this.insuranceNumber = insuranceNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return 0.1 * RentalRate; //10% of rental rate
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Number: " + insuranceNumber);
    }
}

public class Bike : Vehicle
{
    public Bike(string vehicleNumber, string type, double rentalRate) : base(vehicleNumber, "Bike", rentalRate)
    {
    }
    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }
}

public class Truck : Vehicle, IInsurable
{
    private string insuranceNumber;

    public string InsuranceNumber
    {
        get { return insuranceNumber; }
        set { insuranceNumber = value; }
    }
    public Truck(string vehicleNumber, string type, double rentalRate, string insuranceNumber) : base(vehicleNumber, "Truck", rentalRate)
    {
        this.insuranceNumber = insuranceNumber;
    }
    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return 0.2 * RentalRate; //20% of rental rate
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Number: " + insuranceNumber);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Car car = new Car("C1001", "Car", 1000, "I1001");
        vehicles.Add(car);

        Bike bike = new Bike("B1001", "Bike", 500);
        vehicles.Add(bike);

        Truck truck = new Truck("T1001", "Truck", 2000, "I1002");
        vehicles.Add(truck);

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine("Vehicle Number: " + vehicle.VehicleNumber);
            Console.WriteLine("Type: " + vehicle.Type);
            Console.WriteLine("Rental Rate: " + vehicle.RentalRate);
            Console.WriteLine("Rental Cost for 5 days: " + vehicle.CalculateRentalCost(5));

            if (vehicle is IInsurable)
            {
                IInsurable insurable = (IInsurable)vehicle;
                Console.WriteLine("Insurance Amount: " + insurable.CalculateInsurance());
                insurable.GetInsuranceDetails();
            }
            Console.WriteLine();
        }
    }
}