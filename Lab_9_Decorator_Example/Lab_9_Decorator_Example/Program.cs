// Інтерфейс ICoffee, що визначає методи, які мають бути реалізовані
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

// Простий клас SimpleCoffee, що реалізує інтерфейс ICoffee
public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 5.0;
    }
}
// Абстрактний клас CoffeeDecorator, що реалізує інтерфейс ICoffee і зберігає посилання на об'єкт ICoffee
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee decoratedCoffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.decoratedCoffee = coffee;
    }

    public virtual string GetDescription()
    {
        return decoratedCoffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return decoratedCoffee.GetCost();
    }
}
// Клас MilkDecorator, що додає молоко до кави
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return decoratedCoffee.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return decoratedCoffee.GetCost() + 1.5;
    }
}

// Клас SugarDecorator, що додає цукор до кави
public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return decoratedCoffee.GetDescription() + ", Sugar";
    }

    public override double GetCost()
    {
        return decoratedCoffee.GetCost() + 0.5;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Створюємо просту каву
        ICoffee myCoffee = new SimpleCoffee();
        Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");

        // Додаємо молоко до кави
        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");

        // Додаємо цукор до кави з молоком
        myCoffee = new SugarDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");
    }
}

