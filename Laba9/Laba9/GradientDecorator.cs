using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class GradientDecorator : Decorator
    {
        public GradientDecorator(IGraphicComponent component) : base(component) { }

        public override void Draw()
        {
            base.Draw();
            AddGradient();
        }

        private void AddGradient()
        {
            Console.WriteLine("Adding gradients to the graphic component.");
        }
    }

}
