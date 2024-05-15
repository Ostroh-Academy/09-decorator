namespace ConsoleApp1;

internal class ConcreteDecoratorB(Component comp) : Decorator(comp)
{
    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}