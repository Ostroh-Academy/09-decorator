using Laboratory9.Coffee;
using Laboratory9.Coffee.Api;
using Laboratory9.Coffee.Decorators;

namespace Laboratory9;

internal static class Program
{
    private static void Main()
    {
        ShowOffBasicCoffee();
        ShowOffCoffeeWithMilk();
        ShowOffCoffeeWithMilkAndSugar();
        ShowOffCoffeeWithDoubleSugar();
        Console.ReadLine();
    }

    private static void ShowOffBasicCoffee()
    {
        Console.WriteLine();
        Console.WriteLine("Basic coffee:");
        ICoffee basicCoffee = new BasicCoffee();
        Console.WriteLine("Ingredients: " + basicCoffee.GetIngredients());
        Console.WriteLine("Cost: $" + basicCoffee.GetCost());
    }

    private static void ShowOffCoffeeWithMilk()
    {
        Console.WriteLine();
        Console.WriteLine("Coffee with milk:");
        ICoffee coffeeWithMilk = new MilkDecorator(new BasicCoffee());
        Console.WriteLine("Ingredients: " + coffeeWithMilk.GetIngredients());
        Console.WriteLine("Cost: $" + coffeeWithMilk.GetCost());
    }

    private static void ShowOffCoffeeWithMilkAndSugar()
    {
        Console.WriteLine();
        Console.WriteLine("Coffee with milk and sugar:");
        ICoffee coffeeWithMilkAndSugar = new SugarDecorator(new MilkDecorator(new BasicCoffee()));
        Console.WriteLine("Ingredients: " + coffeeWithMilkAndSugar.GetIngredients());
        Console.WriteLine("Cost: $" + coffeeWithMilkAndSugar.GetCost());
    }

    private static void ShowOffCoffeeWithDoubleSugar()
    {
        Console.WriteLine();
        Console.WriteLine("Coffee with double sugar:");
        ICoffee coffeeWithDoubleSugar = new SugarDecorator(new SugarDecorator(new BasicCoffee()));
        Console.WriteLine("Ingredients: " + coffeeWithDoubleSugar.GetIngredients());
        Console.WriteLine("Cost: $" + coffeeWithDoubleSugar.GetCost());
    }
}