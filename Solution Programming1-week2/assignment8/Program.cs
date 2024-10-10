namespace assignment8;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter a number (1-7) to get the day of the week : ");
        int dayNumber = int.Parse(Console.ReadLine());

        string dayName = GetDayOfWeek(dayNumber);

        Console.WriteLine($"The day is : {dayName}");
    }

    string GetDayOfWeek(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid day"; 
        }
    }
}


