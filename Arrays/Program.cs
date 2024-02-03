using System.Collections;

class Program
{
    
    public static void Main()
    {
        // int array with default values
        int[] array1 = new int[5];
        array1[0] = 5;
        array1[1] = 4;
        array1[2] = 3;
        array1[3] = 2;
        array1[4] = 1;
        //array1[5] = 6;// will give array index out of bound

        //Explicitly specify the array type during declaration.
        //Combine values and size during array initialization.
        int[] array2 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        
        //Declare arrays with more than one dimension.// rectangular array
        int[,] matrix = new int[3, 3];

        /*
         Jagged Array Declaration:
         An array of arrays where each element can be an array.
         */
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };

        //Declare an array without specifying initial values
        int[] defaultValues = new int[5];

        // Empty array declaration. 
        int[] emptyArray;

        // array declaration using var 
        var inferredArray = new[] { 1, 2, 3, 4, 5 };

        // arrays length
        int length = array1.Length;

        Console.WriteLine("Iterating Through Array1");
        //Iterating Through Array1
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }

        // sort in array
        Array.Sort(array1);
        Console.WriteLine("after sorting array1");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }

        //get index
        int index = Array.IndexOf(array1, 3);// 0 based index
        Console.WriteLine("index of 3 in array1 is : " + index);

        // passing arrays to methods
        void ModifyArrayIndex0(int[] arr)
        {
            arr[0] = 99;
        }
        ModifyArrayIndex0(array1);
        Console.WriteLine("array1 modified value at index 0 is :" + array1[0]);

        //Arrays as Parameters in Methods
        void printArray(int[] array)
        {
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        Console.WriteLine("calling printArray for array1");
        printArray(array1);


        // Array.Clear  
        //Array.Clear(numbers, startIndex, length);
        Console.WriteLine("clear array1 form index 1 to length of 2 using Array.Clear");
        Array.Clear(array1, 1, 2);
        printArray(array1);


        // Creating an ArrayList
        ArrayList arrayList = new ArrayList();

        // Adding elements to the ArrayList
        arrayList.Add(5);
        arrayList.Add("Hello");
        arrayList.Add(3.14);
        arrayList.Add(true);

        // Accessing elements in the ArrayList
        Console.WriteLine("Elements in the ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Inserting an element at a specific index
        arrayList.Insert(1, "Inserted");

        // Removing an element
        arrayList.Remove(3.14);

        // Accessing elements after modifications
        Console.WriteLine("\nElements after modifications:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // ArrayList Count property
        Console.WriteLine("\nNumber of elements in the ArrayList: " + arrayList.Count);

        // ArrayList Capacity property
        Console.WriteLine("Capacity of the ArrayList: " + arrayList.Capacity);

        // Clearing the ArrayList
        arrayList.Clear();

        // Checking if the ArrayList is empty
        Console.WriteLine("\nIs the ArrayList empty? " + (arrayList.Count == 0 ? "Yes" : "No"));

        //refer an array
        int[] a1 = new int[3] {1,2,3};
        int[] a2 = a1;
        a2[2] = 99;// this will changes the value of a1 also
        Console.WriteLine("value of a1 changed with change in a2 :"+a1[2]);
        // if we copy array then values will not change.and each variable point to it's own copy.
        /*
                private double[] ToCentimeters(params double[] measurements)
                {
                    for (int i = 0; i < measurements.Length; i++)
                    {
                        measurements[i] *= 2.54;
                    }
                    return measurements;
                }
                double[] measurements = this.ToCentimeters(1, 2, 3);*/
        // by params keyword we can use direct list as parameter.
        string[] initials = null;
        //string firstInitial = initials[0].ToUpper();// a statement will throw NullReferenceException.
        // code that uses if statements to prevent a  NullReferenceException.
        if (initials != null)
        {
            if (initials[0] != null)
            {
                string firstInitial = initials[0].ToUpper();
            }
        }
        //A statement that uses nill conditional operators to prevent a  NullReferenceException.
        string firstinitail = initials?[0].ToUpper(); 


    }
}
