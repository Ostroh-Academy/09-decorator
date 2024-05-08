using Laboratory9.Coffee.Api;
using Laboratory9.Coffee.Decorators.Api;

namespace Laboratory9.Coffee.Decorators;

public class MilkDecorator : CoffeeDecorator
{
    private const string MilkName = "Milk";
    private const double MilkCost = 0.5;
    
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetIngredients() =>
        Coffee.GetIngredients() + $", {MilkName}";

    public override double GetCost() =>
        Coffee.GetCost() + MilkCost;
}