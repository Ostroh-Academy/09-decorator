using DecoratorWebExample.Entities.Interfaces;

namespace DecoratorWebExample.Entities;

public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Simple coffee";
    public double GetCost() => 1.0;
}