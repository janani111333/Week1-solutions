using System;
using System.Collections.Generic;
using System.Linq;

// Forecast Strategy Interface
public interface IForecastStrategy
{
    double Forecast(List<double> data);
}

// Average Forecast Strategy
public class AverageForecast : IForecastStrategy
{
    public double Forecast(List<double> data)
    {
        return data.Average();
    }
}

// Growth-based Forecast Strategy
public class GrowthForecast : IForecastStrategy
{
    public double Forecast(List<double> data)
    {
        if (data.Count < 2) return data.Last();
        double growthRate = (data.Last() - data.First()) / data.First();
        return data.Last() * (1 + growthRate);
    }
}

// Forecast Context
public class ForecastContext
{
    private IForecastStrategy strategy;

    public void SetStrategy(IForecastStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void RunForecast(List<double> values)
    {
        double result = strategy.Forecast(values);
        Console.WriteLine($"Forecasted value: ₹{Math.Round(result, 2)}");
    }
}

// Main Program
public class Program
{
    public static void Main(string[] args)
    {
        List<double> monthlyIncome = new List<double> { 40000, 42000, 45000, 47000, 49000 };

        ForecastContext context = new ForecastContext();

        Console.WriteLine("Choose forecast strategy: 1. Average  2. Growth-based");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            context.SetStrategy(new AverageForecast());
        }
        else if (choice == "2")
        {
            context.SetStrategy(new GrowthForecast());
        }
        else
        {
            Console.WriteLine("Invalid option.");
            return;
        }

        context.RunForecast(monthlyIncome);
    }
}

