namespace ConsoleApp1;

internal class ConcreteDecoratorA(Component comp) : Decorator(comp)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}