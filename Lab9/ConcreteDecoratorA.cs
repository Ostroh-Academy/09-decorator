using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component) { }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }

}
