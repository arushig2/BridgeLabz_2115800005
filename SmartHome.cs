using System;

public class Device
{
    public int deviceId;
    public string status;

    public Device(int deviceId, string status)
    {
        this.deviceId = deviceId;
        this.status = status;
    }

    public void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + deviceId);
        Console.WriteLine("Status: " + status);
    }

}

public class Thermostat : Device
{
    public int temperatureSetting;
    public Thermostat(int deviceId, string status, int temperatureSetting) : base(deviceId, status)
    {
        this.temperatureSetting = temperatureSetting;
    }
    public void DisplayStatus()
    {
        Console.WriteLine("Thermostat Details: ");
        base.DisplayStatus();
        Console.WriteLine("Temperature: " + temperatureSetting);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Device device = new Device(1, "On");
        device.DisplayStatus();

        Console.WriteLine();

        Thermostat thermostat = new Thermostat(2, "Off", 25);
        thermostat.DisplayStatus();
    }
}