namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new ConcreteComponent();
            Console.WriteLine("Оригінальна операція компонента:");
            Console.WriteLine(component.Operation());

            IComponent decoratedComponent1 = new ConcreteDecoratorA(component);
            IComponent decoratedComponent2 = new ConcreteDecoratorB(decoratedComponent1);
            Console.WriteLine("\nПісля декорування компонента:");
            Console.WriteLine(decoratedComponent2.Operation());
        }
    }
}
