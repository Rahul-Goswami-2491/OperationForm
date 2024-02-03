class Program
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            //return base.ToString(); // this one is by default in ToString()
            return "Name : "+name+"\n Age : "+ age;
        }

    }
    static void Main(string[] args)
    {
        Person person = new Person("Rahul", 20);
        Console.WriteLine(person.ToString());
        Console.WriteLine("Before ovverride output was: Program+Person");
    }

}