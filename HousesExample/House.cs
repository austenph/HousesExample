using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class House //class declaration and name, default access level is public
    {
        //these are all fields below:
        private string color;
        private int rooms;
        private int size;
        private int doors;

        //adding methods to our class
        public void Paint (string color)
        {
            this.color = color;
        }
        public string CurrentColor( )
        {
            return color;
        }
    }
}
