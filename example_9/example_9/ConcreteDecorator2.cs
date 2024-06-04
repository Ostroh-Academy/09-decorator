using System;
namespace example_9
{
    public class ConcreteDecorator2 : Decorator
    {
        public ConcreteDecorator2(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        void AddedBehavior()
        {
            Console.WriteLine("Added Behavior from ConcreteDecorator2");
        }
    }
}


