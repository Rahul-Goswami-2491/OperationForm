class Program
{
    static void Main()
    {
        // Implicit conversion
        int intValue = 42;
        long longValue = intValue; // Implicit conversion: int to long
                                   // Explicit conversion (casting)
        double doubleValue = 3.14;
        int intFromDouble = (int)doubleValue; // Explicit conversion (casting): double to int

        // Numeric conversion with potential data loss
        int intValueForByte = 255;
        byte byteValue = (byte)intValueForByte; // Numeric conversion with potential data loss: int to byte

        // String conversion
        int intValueFromString;
        string strValue = "123";

        // Using int.TryParse() for string to int conversion
        if (int.TryParse(strValue, out intValueFromString))
        {
            // String conversion: string to int using int.TryParse()
            Console.WriteLine("String to Int Conversion (TryParse): " + intValueFromString);
        }
        else
        {
            Console.WriteLine("Invalid string for conversion.");
        }

        // Nullable conversion
        int? nullableIntValue = 55;

        // Implicit conversion from nullable to non-nullable
        int nonNullableIntValue = nullableIntValue ?? 0;
        Console.WriteLine("Nullable to Non-Nullable Conversion: " + nonNullableIntValue);

        // Custom conversion (hypothetical)
        MyCustomType customType = new MyCustomType(42);
        int intValueFromCustomType = (int)customType; // Hypothetical custom conversion: MyCustomType to int

        // Displaying results
        Console.WriteLine("Implicit Conversion (int to long): " + longValue);
        Console.WriteLine("Explicit Conversion (Casting, double to int): " + intFromDouble);
        Console.WriteLine("Numeric Conversion with Data Loss (int to byte): " + byteValue);
        Console.WriteLine("String Conversion (string to int): " + intValueFromString);
        Console.WriteLine("Custom Conversion (MyCustomType to int): " + intValueFromCustomType);
    }
    public class MyCustomType
    {
        private readonly int value;
        public MyCustomType(int value)
        {
            this.value = value;
        }

        // Hypothetical custom explicit conversion
        public static explicit operator int(MyCustomType customType)
        {
            return customType.value;
        }
    }

    
}
