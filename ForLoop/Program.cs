class Program
{
    static void Main(string[] args)
    {
        /*for (initialization; condition; iteration)
        {
            // Code to be executed in each iteration
        }
        // Initialize a sum variable
        */
        int sum = 0;

        // Example of a for loop with methods and operations
        for (int i = 1; i <= 5; i++)
        {
            // Call a method within the loop
            DisplayIteration(i);

            // Perform an operation (addition) within the loop
            sum += i;
        }

        // Output: Iteration 1
        //         Iteration 2
        //         Iteration 3
        //         Iteration 4
        //         Iteration 5

        // Output the final sum
        Console.WriteLine("Sum of numbers from 1 to 5: {0}", sum);
    }

    // Example method called within the loop
    static void DisplayIteration(int value)
    {
        Console.WriteLine("Iteration "+ value);
    }
    /*int j = 0;
    for (int i = 1; i <= 5; *//* missing iteration expression *//*)
    {
        Console.WriteLine("Iteration "+ j);
        j++;
        // Missing increment or decrement statement (e.g., i++; or i--;)
    }

    // The code here will never be reached due to the infinite loop
    Console.WriteLine("This line will never be executed.");
    */
}