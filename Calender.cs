using System;

class CalendarDisplay{

    public static string GetMonthName(int month){
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    public static bool IsLeapYear(int year){
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
            return true;
        }
        return false;
    }

    public static int GetDaysInMonth(int month, int year){
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        if (month == 2 && IsLeapYear(year)){
            return 29; // February has 29 days in a leap year
        }
        return daysInMonth[month - 1];
    }

    public static int GetFirstDayOfMonth(int month, int year){
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;
        return d0;
    }

    public static void DisplayCalendar(int month, int year){
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);


        Console.WriteLine("\n        " + monthName + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Print spaces for the first day of the month
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    "); 
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            // Print the day with proper indentation
            Console.Write(day.ToString().PadLeft(3) + " ");

            // Move to the next line after Saturday
            if ((firstDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine(); // Move to the next line after the calendar
    }

    static void Main(string[] args)
    {
        // Take user input for month and year
        Console.Write("Enter the month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Display the calendar
        DisplayCalendar(month, year);
    }
}
