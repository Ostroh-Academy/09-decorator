using Laboratory9.Laptops.Api;
using Laboratory9.Laptops.Decorators.Api;

namespace Laboratory9.Laptops.Decorators;

public class LaptopSecretArmyEncryptionDecorator : LaptopDecorator
{
    private const string Feature = "Secret Army Encryption";
    private const double Additional = 755.0;

    public LaptopSecretArmyEncryptionDecorator(ILaptop laptop) : base(laptop) { }

    public override string GetFeatures() =>
        Laptop.GetFeatures() + $", {Feature}";

    public override double GetPrice() =>
        Laptop.GetPrice() + Additional;
}