using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9
{
    interface Comp
    {
        string Operation();
    }

    class ConcreteComponent : Comp
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }
    abstract class Decorator : Comp
    {
        protected Comp component;

        public Decorator(Comp component)
        {
            this.component = component;
        }
        public virtual string Operation()
        {
            return component.Operation();
        }
    }
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Comp component) : base(component)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Comp component) : base(component)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }

}
