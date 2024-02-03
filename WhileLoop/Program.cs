class Program
{
    static void Main(string[] args)
    {
        // Initialize a counter and sum variables
        int counter = 1;
        int sum = 0;

        // Define the while loop condition
        while (counter <= 5)
        {
            // Code to be executed while the condition is true
            Console.WriteLine("Iteration "+ counter);

            // Add the current value of counter to the sum
            sum += counter;

            // Increment the counter
            counter++;
        }

        // Output: Iteration 1
        //         Iteration 2
        //         Iteration 3
        //         Iteration 4
        //         Iteration 5

        // Output the final sum
        Console.WriteLine("Sum of numbers from 1 to 5: "+ sum);

        // Initialize a counter and sum variables
        int counter2 = 1;
        int sum2 = 1;

        // Mistakenly making the loop condition always true
        while (counter2 <= 5)
        {
            Console.WriteLine("Iteration "+ counter2);
            sum2 += counter2;

            // comment the following line to introduce an error (infinite loop)
            //counter2++;

            // solve infinite loop with if condition
            if (sum2 > 15)
            {
                // Break the loop when the condition is met
                break;

            }
        }

        // This line will never be reached due to the infinite loop
        Console.WriteLine("Sum : "+ sum2);

    }
}