using System;

class TravelComputation
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the city you will pass through (via): ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

      
        Console.Write("Enter the distance from the starting city to the via city (in miles): ");
        double distanceFromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from the via city to the destination city (in miles): ");
        double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter the total time taken for the journey (in minutes): ");
        int totalTime = Convert.ToInt32(Console.ReadLine());

        double totalDistance = distanceFromToVia + distanceViaToFinalCity;

        Console.WriteLine($"\nThe Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} miles and the Total Time taken is {totalTime} minutes.");
    }
}
