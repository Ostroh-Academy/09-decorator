using Laboratory9.Coffee.Api;

namespace Laboratory9.Coffee;

public class BasicCoffee : ICoffee
{
    private const double Price = 2.0;
    private const string CoffeeName = "Coffee";
    private const string WaterName = "Water";

    public string GetIngredients() =>
        $"{CoffeeName}, {WaterName}";

    public double GetCost() =>
        Price;
}