using Laboratory9.Laptops.Api;
using Laboratory9.Laptops.Decorators.Api;

namespace Laboratory9.Laptops.Decorators;

public class LaptopBiggerBatteryDecorator : LaptopDecorator
{
    private const string Feature = "Bigger Battery";
    private const double Additional = 750.0;

    public LaptopBiggerBatteryDecorator(ILaptop laptop) : base(laptop) { }

    public override string GetFeatures() =>
        Laptop.GetFeatures() + $", {Feature}";

    public override double GetPrice() =>
        Laptop.GetPrice() + Additional;
}