namespace LAB_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Comp component = new ConcreteComponent();
            Console.WriteLine(component.Operation());

            Comp decoratedComponent = new ConcreteDecoratorA(component);
            Console.WriteLine(decoratedComponent.Operation());

            decoratedComponent = new ConcreteDecoratorB(decoratedComponent);
            Console.WriteLine(decoratedComponent.Operation());
        }
    }
}