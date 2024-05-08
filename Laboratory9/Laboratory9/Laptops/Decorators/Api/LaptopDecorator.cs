using Laboratory9.Laptops.Api;

namespace Laboratory9.Laptops.Decorators.Api;

public abstract class LaptopDecorator : ILaptop
{
    protected readonly ILaptop Laptop;

    protected LaptopDecorator(ILaptop laptop)
    {
        Laptop = laptop;
    }

    public abstract string GetFeatures();

    public abstract double GetPrice();
}