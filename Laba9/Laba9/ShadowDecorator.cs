using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class ShadowDecorator : Decorator
    {
        public ShadowDecorator(IGraphicComponent component) : base(component) { }

        public override void Draw()
        {
            base.Draw();
            AddShadow();
        }

        private void AddShadow()
        {
            Console.WriteLine("Adding shadows to the graphic component.");
        }
    }

}
