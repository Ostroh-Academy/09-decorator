namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            var decorator1 = new ConcreteDecoratorA(simple);
            var decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }
    }
}