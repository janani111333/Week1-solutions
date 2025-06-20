using System;

// Product Interface
public interface IVehicle
{
    void Drive();
}

// Concrete Product 1
public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a Car.");
    }
}

// Concrete Product 2
public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a Bike.");
    }
}

// Factory Class
public class VehicleFactory
{
    public IVehicle GetVehicle(string vehicleType)
    {
        if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
        {
            return new Car();
        }
        else if (vehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
        {
            return new Bike();
        }
        else
        {
            return null;
        }
    }
}

// Main Program
public class Program
{
    public static void Main(string[] args)
    {
        VehicleFactory factory = new VehicleFactory();

        IVehicle vehicle1 = factory.GetVehicle("Car");
        vehicle1?.Drive();

        IVehicle vehicle2 = factory.GetVehicle("Bike");
        vehicle2?.Drive();
    }
}

