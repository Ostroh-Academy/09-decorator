using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9
{
    using System;
    interface IButton
    {
        void Render();
    }
    class SimpleButton : IButton
    {
        private string text;

        public SimpleButton(string text)
        {
            this.text = text;
        }

        public void Render()
        {
            Console.WriteLine($"Кнопка: {text}");
        }
    }
    abstract class ButtonDecorator : IButton
    {
        protected IButton button;

        public ButtonDecorator(IButton button)
        {
            this.button = button;
        }

        public virtual void Render()
        {
            button.Render();
        }
    }
    class IconButtonDecorator : ButtonDecorator
    {
        public IconButtonDecorator(IButton button) : base(button)
        {
        }

        public override void Render()
        {
            base.Render();
            Console.WriteLine("iконка для кнопки");
        }
    } 
    class ItalicButtonDecorator : ButtonDecorator
    {
        public ItalicButtonDecorator(IButton button) : base(button)
        {
        }
        public override void Render()
        {
            base.Render();
            Console.WriteLine("Похилий шрифт");
        }
    }
    class ColorButtonDecorator : ButtonDecorator
    {
        public ColorButtonDecorator(IButton button) : base(button)
        {
        }
        public override void Render()
        {
            base.Render();
            Console.WriteLine("Змiна фону");
        }
    }
}
