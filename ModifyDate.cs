using System;

class ModifyDate{
    static void Main(){
        Console.Write("Enter a date (yyyy-MM-dd): ");
		DateTime inputDate = DateTime.Parse(Console.ReadLine());

        Add 7 days 1 month and 2 years
        DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        
        Subtract 3 weeks (21 days)
        modifiedDate = modifiedDate.AddDays(-21);
        
        Console.WriteLine("Final modified date: " + modifiedDate.ToString("yyyy-MM-dd"));
    }
}
