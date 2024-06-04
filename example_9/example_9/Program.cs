using example_9;

class Program
{
    static void Main(string[] args)
    {
        // Створення базового компонента
        IComponent component = new ConcreteComponent();

        // Додаємо декоратори до компонента
        component = new ConcreteDecorator1(component);
        component = new ConcreteDecorator2(component);

        // Викликаємо операцію
        component.Operation();

        // Вихід з програми
        Console.ReadKey();
    }
}