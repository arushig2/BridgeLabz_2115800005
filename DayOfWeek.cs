// using System;

// class DayOfWeek
// {
    // public static void Main(string[] args)
    // {
        // Take user input for the month
        // Console.Write("Enter a Month (1 for January, 2 for February, etc.): ");
        // int m = Convert.ToInt32(Console.ReadLine());
        
        // Take user input for the day
        // Console.Write("Enter a Day: ");
        // int d = Convert.ToInt32(Console.ReadLine());
        
        // Take user input for the year
        // Console.Write("Enter a Year: ");
        // int y = Convert.ToInt32(Console.ReadLine());
        
        // Calculate y0: the year adjusted for the month
        // int y0 = y - (14 - m) / 12;
        
        // Calculate x: the total number of leap year corrections
        // int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        
        // Calculate m0: the adjusted month
        // int m0 = m + 12 * ((14 - m) / 12) - 2;
        
        // Calculate d0: the day of the week (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
        // int d0 = (d + x + (31 * m0) / 12) % 7;
        
        // Output the day of the week
		// Console.WriteLine("Day: " + d0);
	// }
// }
