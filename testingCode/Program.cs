using System;
class Program
{
    class CustomClass
    {
        private string _name;
        private int _age;

        public CustomClass(string name = "DefaultName", int age = 0)
        {
            name = name;
            age = age;
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
    static void Main(string[] args)
    {
        CustomClass c1 = new CustomClass("Rahul", 20);
        CustomClass c2 = new CustomClass();
        c2.name = "rahul";
        c2.age = 20;
        Console.WriteLine("checking two class objects with Equals() method :");
        Console.WriteLine("c1 name and age :" + c1.name + " " + c1.age);
        Console.WriteLine("c2 name and age :" + c2.name + " " + c2.age);
        Console.WriteLine("Boths are equals: " + c1.Equals(c2));

    }

}