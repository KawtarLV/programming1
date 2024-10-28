namespace assignment13;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        EventScheduler eventScheduler = new EventScheduler(1);

        Console.Write("Enter event name: ");
        string Name = Console.ReadLine();

        Console.Write("Enter event date (YYYY-MM-DD): ");
        string Date = Console.ReadLine();

        Console.Write("Enter event location: ");
        string Location = Console.ReadLine();

        eventScheduler.AddEvent(new Event(Name, Date, Location));
        eventScheduler.DisplayEvents();

        Console.ReadKey();
    }
}

