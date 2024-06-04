using System;
namespace example_9
{
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Doing something...");
        }
    }
}

