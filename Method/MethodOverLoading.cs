using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MethodOverLoading
    {
        public static void Display()
        {
            Console.WriteLine("1st method with no parameters");
        }

        public void Display(int intValue)
        {
            Console.WriteLine("2nd method with int parameter");
        }

        public void Display(string strValue)
        {
            Console.WriteLine("3rd method with string parameter");
        }

        public void Display(int intValue, string strValue)
        {
            Console.WriteLine("4th method with 1st int and then string parameter");
        }

        public void Display(string strValue, int intValue)
        {
            Console.WriteLine("5th method with 1st string and then int parameter");
        }

        public void Add(int one, int two)
        {
            Add(one, two, null);
        }

        public void Add(int one, int two, int[] array)
        {
            int sum = one + two;
            if (array != null)
            {
                foreach (int n in array)
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
        }

        public void CountPara(int one, int two = 2491, int three = 2491, int four = 2491)
        {
            if (two == 2491 && three == 2491 && four == 2491)
            {
                Console.WriteLine("only one parameter is passed and other set to default value");
            }
            if ((two != 2491 && three == 2491 && four == 2491) || (two == 2491 && three != 2491 && four == 2491) || (two == 2491 && three == 2491 && four != 2491))
            {
                Console.WriteLine("two parameter is passed and other set to default value");
            }
            if ((two == 2491 && three != 2491 && four != 2491) || (two != 2491 && three == 2491 && four != 2491) || (two != 2491 && three != 2491 && four == 2491))
            {
                Console.WriteLine("Three parameter is passed and one parameter set to default value");
            }
            if (two != 2491 && three != 2491 && four != 2491)
            {
                Console.WriteLine("All parameters are passed.");
            }
        }

        public void OptionalParaAdd(int one, int two, [Optional] int[] array)
        {
            int sum = one + two;
            if (array == null)
            {
                Console.WriteLine("Optional array is not passed");
            }
            else
            {
                Console.WriteLine("Optional array is passed");
                foreach (int i in array)
                {
                    sum += i;
                }
            }
            Console.WriteLine("sum of elements is : {0}", sum);// we can pass parameters like this also.
        }
    }
}
