using DecoratorWebExample.Entities.Interfaces;

namespace DecoratorWebExample.Entities;

public class MilkDecorator : ICoffeeDecorator
{
    private readonly ICoffee _coffee;
    private readonly double _milkPrice;

    public MilkDecorator(ICoffee coffee)
    {
        _coffee = coffee;
        _milkPrice = 0.5; 
    }

    public ICoffee Coffee => _coffee;

    public string GetDescription() => $"{_coffee.GetDescription()}, milk";
    public double GetCost() => _coffee.GetCost() + _milkPrice;
}