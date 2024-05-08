using Laboratory9.Coffee.Api;
using Laboratory9.Coffee.Decorators.Api;

namespace Laboratory9.Coffee.Decorators;

public class SugarDecorator : CoffeeDecorator
{
    private const string SugarName = "Sugar";
    private const double SugarCost = 0.25;
    
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetIngredients() =>
        Coffee.GetIngredients() + $", {SugarName}";

    public override double GetCost() =>
        Coffee.GetCost() + SugarCost;
}