using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("this is base class!!!!");
        }
    }

    internal class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("this is derived class!");
        }
    }


}
