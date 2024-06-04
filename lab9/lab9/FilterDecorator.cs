using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class FilterDecorator : PhotoDecorator
    {
        private string _filter;

        public FilterDecorator(IPhoto photo, string filter) : base(photo)
        {
            _filter = filter;
        }

        public override void Display()
        {
            base.Display();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            Console.WriteLine($"Applying filter: {_filter}");
        }
    }
}
