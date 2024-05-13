using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{

    // Декоратор для додавання молока до напою
    class MilkDecorator : Beverage
    {
        private Beverage _beverage;

        public MilkDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", молоко";

        public override double Cost()
        {
            return _beverage.Cost() + 0.50;
        }
    }

    // Декоратор для додавання цукру до напою
    class SugarDecorator : Beverage
    {
        private Beverage _beverage;

        public SugarDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", цукор";

        public override double Cost()
        {
            return _beverage.Cost() + 0.25;
        }
    }
}