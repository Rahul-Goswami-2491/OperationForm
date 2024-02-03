public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        // Using enums in variables
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine("Today is: "+today);

        // Switch statement with enums
        switch (today)
        {
            case DaysOfWeek.Monday:
            case DaysOfWeek.Wednesday:
            case DaysOfWeek.Friday:
                Console.WriteLine("It's a weekday.");
                break;

            case DaysOfWeek.Saturday:
            case DaysOfWeek.Sunday:
                Console.WriteLine("It's the weekend!");
                break;

            default:
                Console.WriteLine("Invalid day");
                break;
        }

        // Iterating through enum values
        Console.WriteLine("All days of the week:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }
    }
}