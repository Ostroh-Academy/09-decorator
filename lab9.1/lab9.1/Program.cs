using System;

// Клас, що визначає базовий інтерфейс
public interface IComponent
{
    string Operation();
}

// Конкретна реалізація базового класу
public class ConcreteComponent : IComponent
{
    public string Operation()
    {
        return "ConcreteComponent: базова функціональність\n";
    }
}

// Базовий клас декоратора
public abstract class Decorator : IComponent
{
    protected IComponent _component;

    public Decorator(IComponent component)
    {
        this._component = component;
    }

    public virtual string Operation()
    {
        return this._component.Operation();
    }
}

// Конкретний декоратор
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component)
    {
    }

    public override string Operation()
    {
        return base.Operation() + "ConcreteDecoratorA: додаткова функціональність\n";
    }
}

// Конкретний декоратор
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component)
    {
    }

    public override string Operation()
    {
        return base.Operation() + "ConcreteDecoratorB: інша додаткова функціональність\n";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта базового класу
        IComponent component = new ConcreteComponent();
        Console.WriteLine("Client: Я отримав простий компонент:");
        Console.WriteLine(component.Operation());

        // Додаємо декоратори до базового об'єкта
        Decorator decorator1 = new ConcreteDecoratorA(component);
        Decorator decorator2 = new ConcreteDecoratorB(decorator1);
        Console.WriteLine("\nClient: Тепер я отримав декорований компонент:");
        Console.WriteLine(decorator2.Operation());
    }
}
