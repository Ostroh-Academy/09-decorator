using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public abstract class PhotoDecorator : IPhoto
    {
        protected IPhoto _photo;

        public PhotoDecorator(IPhoto photo)
        {
            _photo = photo;
        }

        public virtual void Display()
        {
            _photo.Display();
        }
    }
}
