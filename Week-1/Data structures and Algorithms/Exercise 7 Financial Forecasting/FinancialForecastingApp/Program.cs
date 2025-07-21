using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the present value: ");
        double presentValue = double.Parse(Console.ReadLine()!);

        Console.Write("Enter the annual growth rate (%): ");
        double growthRate = double.Parse(Console.ReadLine()!) / 100;

        Console.Write("Enter the number of years to forecast: ");
        int years = int.Parse(Console.ReadLine()!);

        double futureValue = CalculateFutureValue(presentValue, growthRate, years);
        Console.WriteLine($"\nFuture value after {years} years: ${futureValue:F2}");
    }

    static double CalculateFutureValue(double presentValue, double growthRate, int years)
    {
        if (years == 0)
        {
            return presentValue;
        }
        return CalculateFutureValue(presentValue, growthRate, years - 1) * (1 + growthRate);
    }
}
