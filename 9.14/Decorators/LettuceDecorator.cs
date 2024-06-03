using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._14.Decorators
{
    public class LettuceDecorator : BurgerDecorator
    {
        public LettuceDecorator(BurgerSystem.Burgers.Burger burger) : base(burger) { }

        public override double GetCost()
        {
            return _burger.GetCost() + 0.50; // ціна салату
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Lettuce";
        }
    }
}
