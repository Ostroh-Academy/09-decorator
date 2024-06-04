using System;
namespace example_9
{
    public class ConcreteDecorator1 : Decorator
    {
        public ConcreteDecorator1(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        void AddedBehavior()
        {
            Console.WriteLine("Added Behavior from ConcreteDecorator1");
        }
    }
}

