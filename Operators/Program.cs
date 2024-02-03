 class Program
{
    static void Main() 
    {
        // Arithmetic Operators
        int a = 10, b = 3;
        int sum = a + b;        // Addition
        int difference = a - b; // Subtraction
        int product = a * b;    // Multiplication
        int quotient = a / b;   // Division
        int remainder = a % b;  // Modulus
        Console.WriteLine("Arithmetic Operators:\n Sum:" +sum+", Difference: "+difference+", Product: "+product+", Quotient: "+quotient+" Remainder: "+remainder);

        // Comparison Operators
        bool isEqual = (a == b);    // Equal to
        bool isNotEqual = (a != b); // Not equal to
        bool isGreaterThan = (a > b);   // Greater than
        bool isLessThanOrEqual = (a <= b); // Less than or equal to

        Console.WriteLine("Comparison Operators:\nEqual: "+isEqual+", Not Equal: "+isNotEqual+", Greater Than: "+isGreaterThan+", Less Than or Equal To: "+isLessThanOrEqual+"\n");

        // Logical Operators
        bool logicalAnd = (true && false);   // Logical AND
        bool logicalOr = (true || false && true);    // Logical OR
        bool logicalNot = !true;// Logical NOT
        bool logicalXor = (false ^ false);// Logical XOR

        Console.WriteLine("Logical Operators:\nLogical AND: "+logicalAnd+", Logical OR: "+logicalOr+", Logical XOR: "+logicalXor+", Logical NOT: "+logicalNot+"\n");

        // Assignment Operators
        int x = 5;
        x += 3; // Equivalent to: x = x + 3;

        int y = 8;
        y -= 2; // Equivalent to: y = y - 2;

        Console.WriteLine("Assignment Operators:\nx after +=: "+x+", y after -=: "+y+"\n");

        // Increment and Decrement Operators
        int num = 7;
        num++; // Increment by 1
        num--; // Decrement by 1

        Console.WriteLine("Increment and Decrement Operators:\nnum after increment and decrement: "+num);
    }
}