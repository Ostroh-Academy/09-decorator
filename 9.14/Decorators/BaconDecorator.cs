using _9._14.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._14.Decorators
{
    public class BaconDecorator : BurgerDecorator
    {
        public BaconDecorator(Burger burger) : base(burger) { }

        public override double GetCost()
        {
            return _burger.GetCost() + 1.50; // ціна бекону
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", Bacon";
        }
    }

}
