using System;

public interface IComponent
{
    void Operation();
}

public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("Doing something...");
    }
}

// Декоратор
public abstract class Decorator : IComponent
{
    protected IComponent component;

    public Decorator(IComponent component)
    {
        this.component = component;
    }

    public virtual void Operation()
    {
        if (component != null)
            component.Operation();
    }
}

// Конкретний декоратор, який додає додаткову функціональність
public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
    }

    private void AddedBehavior()
    {
        Console.WriteLine("Added behavior...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IComponent component = new ConcreteComponent();

        component = new ConcreteDecorator(component);

        component.Operation();

        Console.ReadKey();
    }
}
