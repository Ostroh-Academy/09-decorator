using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class ConcreteComponent : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }

}
