using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    // Базовий клас напою
    abstract class Beverage
    {
        public abstract string Description { get; }
        public abstract double Cost();
    }

    // Конкретний клас напою: кава
    class Coffee : Beverage
    {
        public override string Description => "Кава";

        public override double Cost()
        {
            return 1.50;
        }
    }
}
