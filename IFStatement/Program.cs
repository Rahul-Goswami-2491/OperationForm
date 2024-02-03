class Program
{
    static void Main()
    {
        // Example 1: Basic if statement
        int num = 10;
        if (num > 0)
        {
            Console.WriteLine("Example 1: The number is positive.");
        }

        // Example 2: if-else statement
        int x = 5;
        if (x % 2 == 0)
        {
            Console.WriteLine("Example 2: The number is even.");
        }
        else
        {
            Console.WriteLine("Example 2: The number is odd.");
        }

        // Example 3: Nested if statements
        int a = 7, b = 4, c = 9;
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Example 3: 'a' is the largest.");
            }
            else
            {
                Console.WriteLine("Example 3: 'c' is the largest.");
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Example 3: 'b' is the largest.");
            }
            else
            {
                Console.WriteLine("Example 3: 'c' is the largest.");
            }
        }

        // Example 4: if-else if-else ladder
        int score = 85;
        if (score >= 90)
        {
            Console.WriteLine("Example 4: Grade A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Example 4: Grade B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Example 4: Grade C");
        }
        else
        {
            Console.WriteLine("Example 4: Grade F");
        }

        // Example 5: Ternary operator
        int number = 42;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine($"Example 5: The number is {result}.");

        // Example 6: Short-circuiting with && and ||
        int value1 = 5, value2 = 10;
        if (value1 > 0 && value2 > 0)
        {
            Console.WriteLine("Example 6: Both values are positive.");
        }

        if (value1 > 0 || value2 > 0)
        {
            Console.WriteLine("Example 6: At least one value is positive.");
        }

        
    }
}