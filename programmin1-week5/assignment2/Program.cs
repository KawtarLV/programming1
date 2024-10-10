namespace assignment2;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.WriteLine("Enter a day of the week (e.g., Monday): ");
        string input = Console.ReadLine();

        Day day = (Day)Enum.Parse(typeof(Day), input, true);

        switch ( day)
        {
            case Day.Monday:
            case Day.Tuesday:
            case Day.Wednesday:
            case Day.Thursday:
            case Day.Friday:
                Console.WriteLine("Weekend is loading…");
                break;

            case Day.Saturday:
            case Day.Sunday:
                Console.WriteLine("It's weekend!! Party time!");
                break;

        }
    }

}


