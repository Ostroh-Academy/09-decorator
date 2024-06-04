using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class FrameDecorator : PhotoDecorator
    {
        private string _frame;

        public FrameDecorator(IPhoto photo, string frame) : base(photo)
        {
            _frame = frame;
        }

        public override void Display()
        {
            base.Display();
            ApplyFrame();
        }

        private void ApplyFrame()
        {
            Console.WriteLine($"Applying frame: {_frame}");
        }
    }
}
