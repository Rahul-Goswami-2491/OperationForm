using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private static int totalPersons = 0;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            totalPersons++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}, Age : {Age} ");
        }
        public  static int GetTotalPersons()
        {
            return totalPersons;
        }
    }
}
