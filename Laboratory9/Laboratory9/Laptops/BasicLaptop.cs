using Laboratory9.Laptops.Api;

namespace Laboratory9.Laptops;

public class BasicLaptop : ILaptop
{
    private const double BasePrice = 1000.0;
    private const string BaseFeatures = "Basic laptop features";

    public string GetFeatures() =>
        BaseFeatures;

    public double GetPrice() =>
        BasePrice;
}