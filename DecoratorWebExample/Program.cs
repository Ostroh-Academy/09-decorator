using DecoratorWebExample.Entities;
using DecoratorWebExample.Entities.Interfaces;

namespace DecoratorWebExample;

public static class Program
{
    private static void Main()
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine(coffee.GetDescription() + ": $" + coffee.GetCost());

        coffee = new MilkDecorator(coffee);
        Console.WriteLine(coffee.GetDescription() + ": $" + coffee.GetCost());

        coffee = new WhipDecorator(coffee);
        Console.WriteLine(coffee.GetDescription() + ": $" + coffee.GetCost());
    }
}