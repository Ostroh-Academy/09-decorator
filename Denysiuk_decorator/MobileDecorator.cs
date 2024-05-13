using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denysiuk_decorator
{
    // Абстрактний декоратор для мобільного доступу
    abstract class MobileDecorator : Decorator
    {
        protected MobileDecorator(Component component) : base(component)
        {
        }

        public abstract string MobileOptimizedOperation();
    }

    // Конкретний декоратор для оптимізації мобільного доступу
    class MobileOptimizedDecorator : MobileDecorator
    {
        public MobileOptimizedDecorator(Component component) : base(component)
        {
        }

        public override string MobileOptimizedOperation()
        {
            // Логіка оптимізації мобільного доступу
            string result = base.Operation();
            result = OptimizeControlsAndLayout(result);
            return result;
        }

        private string OptimizeControlsAndLayout(string content)
        {
            // Примітивна реалізація оптимізації макету для наочності
            return "<div style='max-width: 480px;'>" + content + "</div>";
        }
    }
}
