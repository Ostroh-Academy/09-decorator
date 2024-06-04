using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Photo : IPhoto
    {
        private string _name;

        public Photo(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Displaying photo: {_name}");
        }
    }
}
