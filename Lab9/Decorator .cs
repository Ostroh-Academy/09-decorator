using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual string Operation()
        {
            return _component.Operation();
        }
    }
}
