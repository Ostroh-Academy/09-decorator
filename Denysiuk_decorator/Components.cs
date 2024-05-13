using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denysiuk_decorator
{
    // Базовий інтерфейс компонента
    public abstract class Component
    {
        public abstract string Operation();
    }

    // Конкретний компонент
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
