using System;

class ZaraBonusCalculator
{
    // Method to generate salaries and years of service for 10 employees
    public static int[,] GenerateEmployeeData(int employeeCount)
    {
        int[,] employeeData = new int[employeeCount, 2];
        Random random = new Random();

        for (int i = 0; i < employeeCount; i++)
        {
            employeeData[i, 0] = random.Next(10000, 100000); // Random 5-digit salary
            employeeData[i, 1] = random.Next(1, 11); // Years of service between 1 and 10
        }

        return employeeData;
    }

    // Method to calculate new salary and bonus
    public static double[,] CalculateNewSalaryAndBonus(int[,] employeeData)
    {
        int employeeCount = employeeData.GetLength(0);
        double[,] updatedData = new double[employeeCount, 2];

        for (int i = 0; i < employeeCount; i++)
        {
            int salary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];

            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusPercentage;
            double newSalary = salary + bonus;

            updatedData[i, 0] = newSalary;
            updatedData[i, 1] = bonus;
        }

        return updatedData;
    }

    // Method to calculate and display totals
    public static void DisplaySummary(int[,] employeeData, double[,] updatedData)
    {
        Console.WriteLine("Employee\tOld Salary\t\tYears of Service\tNew Salary\t\tBonus");

        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            int oldSalary = employeeData[i, 0];
            int yearsOfService = employeeData[i, 1];
            double newSalary = updatedData[i, 0];
            double bonus = updatedData[i, 1];

            Console.WriteLine((i + 1) + "\t\t" + oldSalary + "\t\t" + yearsOfService + "\t\t\t" + newSalary + "\t\t" + bonus);

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;
        }

        Console.WriteLine("\nTotals:\t\t" + totalOldSalary + "\t\t\t\t\t" + totalNewSalary + "\t\t" + totalBonus);
    }

    static void Main(string[] args)
    {
        const int employeeCount = 10;

        int[,] employeeData = GenerateEmployeeData(employeeCount);
        double[,] updatedData = CalculateNewSalaryAndBonus(employeeData);

        DisplaySummary(employeeData, updatedData);
    }
}
