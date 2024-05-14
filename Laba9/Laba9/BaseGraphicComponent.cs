using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class BaseGraphicComponent : IGraphicComponent
    {
        public void Draw()
        {
            Console.WriteLine("Drawing base graphic component.");
        }
    }

}
