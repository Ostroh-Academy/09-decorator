using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public abstract class Decorator : IGraphicComponent
    {
        protected IGraphicComponent _component;

        public Decorator(IGraphicComponent component)
        {
            _component = component;
        }

        public virtual void Draw()
        {
            _component.Draw();
        }
    }

}
