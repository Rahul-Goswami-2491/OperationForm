using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BaseClass1
    {
        public void Display()
        {
            Console.WriteLine("This is base class no 1");
        }
    }
    internal class DerivedClass1 : BaseClass1
    {
        //this will not gonna inherite to base class as it is hidden. 
        public new void Display()
        {
            Console.WriteLine("this is derived class no 1");
        }
    }

}
