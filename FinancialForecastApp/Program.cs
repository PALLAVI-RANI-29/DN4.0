using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user input
        Console.Write("Enter the initial amount: ");
        double initialValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the annual growth rate (in %): ");
        double growthRatePercent = Convert.ToDouble(Console.ReadLine());
        double growthRate = growthRatePercent / 100;  // Convert % to decimal

        Console.Write("Enter the number of years to forecast: ");
        int years = Convert.ToInt32(Console.ReadLine());

        // Calculate future value recursively
        double futureValue = ForecastRecursive(initialValue, growthRate, years);

        Console.WriteLine($"\nFuture value after {years} years: {futureValue:C}");
    }

    static double ForecastRecursive(double currentValue, double growthRate, int years)
    {
        if (years == 0)
            return currentValue;

        return ForecastRecursive(currentValue * (1 + growthRate), growthRate, years - 1);
    }
}
