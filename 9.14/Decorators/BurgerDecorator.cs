using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._14.Decorators
{
    public abstract class BurgerDecorator : Burger
    {
        protected Burger _burger;

        public BurgerDecorator(Burger burger)
        {
            _burger = burger;
        }

        public virtual double GetCost()
        {
            return _burger.GetCost();
        }

        public virtual string GetDescription()
        {
            return _burger.GetDescription();
        }
    }

}
