using Laboratory9.Laptops;
using Laboratory9.Laptops.Api;
using Laboratory9.Laptops.Decorators;

namespace Laboratory9;

internal static class Program
{
    private static void Main()
    {
        ShowOffBasicLaptop();
        ShowOffLaptopWithAllMilitaryFeatures();
        Console.ReadLine();
    }

    private static void ShowOffBasicLaptop()
    {
        Console.WriteLine();
        Console.WriteLine("Basic Laptop:");
        ILaptop basicLaptop = new BasicLaptop();
        Console.WriteLine("Description: " + basicLaptop.GetFeatures());
        Console.WriteLine("Price: $" + basicLaptop.GetPrice());
    }

    private static void ShowOffLaptopWithAllMilitaryFeatures()
    {
        Console.WriteLine();
        Console.WriteLine("Laptop with all military Features:");
        ILaptop laptopWithMilitary = new LaptopSecretArmyEncryptionDecorator(
            new LaptopSatelliteConnectionDecorator(
                new LaptopBiggerBatteryDecorator(
                    new LaptopAdvanceProtectionDecorator(
                        new BasicLaptop()))));
        
        Console.WriteLine("Description: " + laptopWithMilitary.GetFeatures());
        Console.WriteLine("Price: $" + laptopWithMilitary.GetPrice());
    }
}