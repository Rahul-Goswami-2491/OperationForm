using Methods;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using shtAlias = Method.Models.Aliases.Taking;

namespace Method
{
    class Program
    {
        // method for optional parameters
        public static int Add(int one, int two, int three = 0)
        {
            int sum = one + two + three;
            return sum;
        }
        public static void Main(string[] args)
        {
            ///OPTIONAL PARAMETERS
            Console.WriteLine("OPTIONAL PARAMETERS");
            int ans = 0;
            ans = Add(1, 2, 3);
            Console.WriteLine("Add method with 3 parameters: " + ans);
            ans = Add(1, 2);// third is optional.
            Console.WriteLine("Add method with 2 parameters: " + ans);
            Console.WriteLine();
            /// METHOD OVERRIDING
            Console.WriteLine("METHOD OVERRIDING");
            // this will override the method to chld's method when pointing to child class.
            BaseClass bClass = new DerivedClass();
            bClass.Display();// this will use it's childs property.
            DerivedClass dClass = new DerivedClass();
            dClass.Display();
            Console.WriteLine();

            /// METHOD HIDING.
            Console.WriteLine("METHOD HIDING");
            // This will hide method of children when parent class is pointing to children class
            BaseClass1 bClass1 = new DerivedClass1();
            bClass1.Display();
            DerivedClass1 dClass1 = new DerivedClass1();
            dClass1.Display();
            Console.WriteLine();


            ///METHOD OVERLOADING
            Console.WriteLine("METHOD OVERLOADING");
            // same names  of methods but different parameteres.
            MethodOverLoading overLoad = new MethodOverLoading();
            MethodOverLoading.Display();// static method call.
            overLoad.Display(20);// non static method, so we need instance
            overLoad.Display("Rahul");
            overLoad.Display(20, "Rahul");
            overLoad.Display("Rahul", 20);// order in parameters also matters
            Console.WriteLine();

            ///Method parameters optional using method overloading 
            Console.WriteLine("Method parameters optional using method overloading");
            int one = 1;
            int two = 2;
            int[] array = { 3, 4, 5, 6, 7 };

            // using method overloading make optional parameter
            Console.WriteLine("Method with three parameters int + int + array elements");
            overLoad.Add(one, two, array);
            Console.WriteLine("Method with two parameters int+ int and third one is optional so we don't put");
            overLoad.Add(one, two);
            Console.WriteLine();

            /// Method parameters optional by specifying parameter defaults
            overLoad.CountPara(1);
            overLoad.CountPara(1, 2);
            overLoad.CountPara(1, 2, 3);
            overLoad.CountPara(1, 2, 3, 4);
            Console.WriteLine("three parameters pass  with third parameter optional(default) , parameters passed with name");
            overLoad.CountPara(one: 1, two: 2, four: 4);
            Console.WriteLine("two parameters passed with first without name and 2nd to forth position with name");
            overLoad.CountPara(1, four: 4);
            Console.WriteLine();

            /// Making method parameters optional by using OptionalAttribute
            overLoad.OptionalParaAdd(one, two);
            overLoad.OptionalParaAdd(one, two, array);

            ///NAMESPACE
            Method.Data.DataAccess acess = new Method.Data.DataAccess();// here we using namespace Method so don't need to write Method, just like we don't write System in writeLine.
            Data.DataAccess dataAccess = new Data.DataAccess();// namespace Method so we don't need Method to write.
            dataAccess.FirstName = "Rahul";
            dataAccess.LastName = "Goswami";
            Data.PersonModel person = new Data.PersonModel();
            Models.PersonModel personModel = new Models.PersonModel();
            /*if we add using of both like 
                using Method.Data;
                using Method.Models;

            and then we try to acess like 
                PersonModel model  = new Data.PersonModel();
                PersonModel personModel = new Models.PersonModel();
            then it causes error 'PersonModel' is an ambiguous reference between 'Method.Data.PersonModel' and 'Method.Models.PersonModel'	
            */
            //for alias 
            shtAlias.Alias alias = new shtAlias.Alias();// we can give short name or other names as alias in using like this using shtAlias = Method.Models.Aliases.Taking;

            ///CLASS
            ///STATIC AND INSTANCE MEMBERS
           




        }
    }

}
