using _9._14.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._14.Decorators
{
    public class CheeseDecorator : BurgerDecorator
    {
        public CheeseDecorator(Burger burger) : base(burger) { }

        public override double GetCost()
        {
            return _burger.GetCost() + 1.00; // ціна сиру
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Cheese";
        }
    }

}
