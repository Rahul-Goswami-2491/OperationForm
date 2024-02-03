class Program
{
    public static void Main(string[] args)
    {
        // defining Nullable type
        Nullable<int> n = null;

        // using the method
        // output will be 0 as default 
        // value of null is 0
        Console.WriteLine("n :" + n.GetValueOrDefault());

        // defining Nullable type
        int? n1 = null;

        // using the method
        // output will be 0 as default 
        // value of null is 0
        Console.WriteLine("n1 :"+n1.GetValueOrDefault());


        // using Nullable type syntax 
        // to define non-nullable
        int? n2 = 47;

        // using the method
        Console.WriteLine("n2 :" + n2.GetValueOrDefault());

        // using Nullable type syntax 
        // to define non-nullable
        Nullable<int> n3 = 457;

        // using the method
        Console.WriteLine("n3 :" + n3.GetValueOrDefault());


        // a is nullable type
        // and contains null value
        int? a = null;

        // b is nullable type int
        // and behave as a normal int
        int? b = 2345;

        // this will not print
        // anything on console
        Console.WriteLine("a :"+a);

        // gives 2345 as output
        Console.WriteLine("b :"+b);
    }
}