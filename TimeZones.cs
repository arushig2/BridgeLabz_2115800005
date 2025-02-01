using System;

class TimeZones{
    static void Main()
    {
        //Get the current UTC time as DateTimeOffset
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        Console.WriteLine("UTC Time: " + utcNow);

        //List of time zones to convert to
        string[] timeZoneIds ={"Eastern Standard Time", "India Standard Time", "Pacific Standard Time"};

        //Convert and display the time in different time zones
        for(int i = 0; i < timeZoneIds.Length; i++){
           DateTimeOffset targetTime = ConvertToTimeZone(utcNow, timeZoneIds[i]);
           Console.WriteLine($"{timeZoneIds[i]}: {targetTime}");
        }
    }
	
    static DateTimeOffset ConvertToTimeZone(DateTimeOffset utcTime, string timeZoneId){
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        return TimeZoneInfo.ConvertTime(utcTime, timeZone);
    }
}
