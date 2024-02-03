public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person otherPerson = (Person)obj;
        return string.Equals(Name, otherPerson.Name, StringComparison.OrdinalIgnoreCase);
    }

}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Rahul");
        Person person2 = new Person("rahul");

        // Using overridden Equals method
        bool areEqual = person1.Equals(person2);
        Console.WriteLine("Are persons equal? "+areEqual); // Output: Are persons equal? True
    }
}
