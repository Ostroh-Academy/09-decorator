using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._14.Burgers
{
    public class BasicBurger : Burger
    {
        public double GetCost()
        {
            return 5.00; // базова ціна
        }

        public string GetDescription()
        {
            return "Basic Burger";
        }
    }

}
