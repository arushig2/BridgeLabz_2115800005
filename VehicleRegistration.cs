using System;

public class Vehicle
{
   
    public static double RegistrationFee = 5000.0;
    public string OwnerName;
    public string VehicleType;
    public readonly int RegistrationNumber;

  
    public Vehicle(string ownerName, string vehicleType, int registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }

   
    public static void UpdateRegistrationFee()
    {
        Console.Write("Enter updated registration fee: ");
        RegistrationFee = Convert.ToDouble(Console.ReadLine());
    }

 
    public void DisplayDetails()
    {
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
        Console.WriteLine($"Registration Number: {RegistrationNumber}");
        Console.WriteLine($"Registration Fee: {RegistrationFee}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        object obj1 = new Vehicle("Alice", "Car", 1001);
        object obj2 = new Vehicle("Bob", "Bike", 1002);
        object obj3 = "Not a Vehicle";

     
        if (obj1 is Vehicle vehicle1)
        {
            vehicle1.DisplayDetails();
        }
        else
        {
            Console.WriteLine("obj1 is not an instance of Vehicle.");
        }

        
        Vehicle.UpdateRegistrationFee();


        if (obj2 is Vehicle vehicle2)
        {
            vehicle2.DisplayDetails();
        }
        else
        {
            Console.WriteLine("obj2 is not an instance of Vehicle.");
        }


        if (obj3 is Vehicle vehicle3)
        {
            vehicle3.DisplayDetails();
        }
        else
        {
            Console.WriteLine("obj3 is not an instance of Vehicle.");
        }
    }
}
