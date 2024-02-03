class Program
{
    static void Main(string[] args)
    {
        char grade = 'c';
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
            case 'C':
                Console.WriteLine("Well done.");
                break;
            case 'D':
                Console.WriteLine("You passed.");
            //missing break statement  // Error : Control cannot fall through from one case label('case 'D':') to another
            case 123: //Error: Incorrect data type (int instead of char)
                Console.WriteLine("Better luck next time.");
                break;
            case 'A': // Duplicate case label 'A'//Error: The switch statement contains multiple cases with the label value 'A'
                Console.WriteLine("Duplicate case!");
                break;
            default:
                Console.WriteLine("Invalid grade.");
                break;
        }

    }
}