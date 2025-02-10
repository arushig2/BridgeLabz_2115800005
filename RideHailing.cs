using System;

public abstract class Vehicle
{
    private string vehicleID;
    private string driverName;
    private double ratePerKm;

    public string VehicleID
    {
        get { return vehicleID; }
        set { vehicleID = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    public Vehicle(string vehicleID, string driverName, double ratePerKm)
    {
        this.vehicleID = vehicleID;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleID);
        Console.WriteLine("Driver Name: " + driverName);
        Console.WriteLine("Rate per km: " + ratePerKm);
    }
}
public interface IGPS
{
    public void GetCurrentLocation();
    public void UpdateLocation();
}

public class  Bike : Vehicle, IGPS
{
    private string bikeModel;
    private string bikeNumber;
    public string BikeModel
    {
        get { return bikeModel; }
        set { bikeModel = value; }
    }
    public string BikeNumber
    {
        get { return bikeNumber; }
        set { bikeNumber = value; }
    }
    public Bike(string vehicleID, string driverName, double ratePerKm, string bikeModel, string bikeNumber) : base(vehicleID, driverName, ratePerKm)
    {
        this.bikeModel = bikeModel;
        this.bikeNumber = bikeNumber;
    }
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
    public void GetCurrentLocation()
    {
        Console.WriteLine("Current location of bike is: ");
    }
    public void UpdateLocation()
    {
        Console.WriteLine("Location updated successfully");
    }

}

public class Car : Vehicle, IGPS
{
    private string carModel;
    private string carNumber;
    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }
    public string CarNumber
    {
        get { return carNumber; }
        set { carNumber = value; }
    }
    public Car(string vehicleID, string driverName, double ratePerKm, string carModel, string carNumber) : base(vehicleID, driverName, ratePerKm)
    {
        this.carModel = carModel;
        this.carNumber = carNumber;
    }
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
    public void GetCurrentLocation()
    {
        Console.WriteLine("Current location of car is: ");
    }
    public void UpdateLocation()
    {
        Console.WriteLine("Location updated successfully");
    }
}

public class Auto : Vehicle, IGPS
{
    private string autoModel;
    private string autoNumber;
    public string AutoModel
    {
        get { return autoModel; }
        set { autoModel = value; }
    }
    public string AutoNumber
    {
        get { return autoNumber; }
        set { autoNumber = value; }
    }
    public Auto(string vehicleID, string driverName, double ratePerKm, string autoModel, string autoNumber) : base(vehicleID, driverName, ratePerKm)
    {
        this.autoModel = autoModel;
        this.autoNumber = autoNumber;
    }
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
    public void GetCurrentLocation()
    {
        Console.WriteLine("Current location of auto is: ");
    }
    public void UpdateLocation()
    {
        Console.WriteLine("Location updated successfully");
    }
}

public class Program
{
    public static void Main()
    {
        Car car = new Car("C101", "John", 10, "SUV", "KA01AB1234");
        car.GetVehicleDetails();
        Console.WriteLine("Fare: " + car.CalculateFare(20));
        car.GetCurrentLocation();
        car.UpdateLocation();
        Bike bike = new Bike("B101", "Mike", 5, "Mountain Bike", "KA01AB5678");
        bike.GetVehicleDetails();
        Console.WriteLine("Fare: " + bike.CalculateFare(10));
        bike.GetCurrentLocation();
        bike.UpdateLocation();
        Auto auto = new Auto("A101", "Tom", 8, "Passenger Auto", "KA01AB9876");
        auto.GetVehicleDetails();
        Console.WriteLine("Fare: " + auto.CalculateFare(15));
        auto.GetCurrentLocation();
        auto.UpdateLocation();
    }
}