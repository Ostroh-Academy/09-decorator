using Laboratory9.Coffee.Api;

namespace Laboratory9.Coffee.Decorators.Api;

public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee Coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        Coffee = coffee;
    }

    public abstract string GetIngredients();

    public abstract double GetCost();
}