using Laboratory9.Laptops.Api;
using Laboratory9.Laptops.Decorators.Api;

namespace Laboratory9.Laptops.Decorators;

public class LaptopAdvanceProtectionDecorator : LaptopDecorator
{
    private const string Feature = "Advance Protection";
    private const double Additional = 1000.0;

    public LaptopAdvanceProtectionDecorator(ILaptop laptop) : base(laptop) { }

    public override string GetFeatures() =>
        Laptop.GetFeatures() + $", {Feature}";

    public override double GetPrice() =>
        Laptop.GetPrice() + Additional;
}