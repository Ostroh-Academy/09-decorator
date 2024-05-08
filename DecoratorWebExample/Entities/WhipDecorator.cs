using DecoratorWebExample.Entities.Interfaces;

namespace DecoratorWebExample.Entities;

public class WhipDecorator : ICoffeeDecorator
{
    private readonly ICoffee _coffee;
    private readonly double _whipPrice;

    public WhipDecorator(ICoffee coffee)
    {
        _coffee = coffee;
        _whipPrice = 0.7;
    }

    public ICoffee Coffee => _coffee;

    public string GetDescription() => $"{_coffee.GetDescription()}, whip";
    public double GetCost() => _coffee.GetCost() + _whipPrice;
}