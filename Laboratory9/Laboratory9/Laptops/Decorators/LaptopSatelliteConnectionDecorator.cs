using Laboratory9.Laptops.Api;
using Laboratory9.Laptops.Decorators.Api;

namespace Laboratory9.Laptops.Decorators;

public class LaptopSatelliteConnectionDecorator : LaptopDecorator
{
    private const string Feature = "Satellite Connection";
    private const double Additional = 500.0;

    public LaptopSatelliteConnectionDecorator(ILaptop laptop) : base(laptop) { }

    public override string GetFeatures() =>
        Laptop.GetFeatures() + $", {Feature}";

    public override double GetPrice() =>
        Laptop.GetPrice() + Additional;
}