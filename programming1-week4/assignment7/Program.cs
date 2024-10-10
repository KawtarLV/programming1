namespace assignment7;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        bool[] seats = new bool[10];
        InitializeSeats(seats);
        DisplaySeatingArrangement(seats);

        Console.Write("Enter the seat number to book (1-10):");
        int seatNumber = int.Parse(Console.ReadLine());

        BookSeat(seats, seatNumber - 1);

        DisplaySeatingArrangement(seats);
    }
    void InitializeSeats(bool[] seats)
    {
        Random random = new Random();
        for (int i=0;i<seats.Length; i++)
        {
            seats[i] = random.Next(0, 2) == 0;
        }
    }

    void DisplaySeatingArrangement(bool[] seats)
    {
        Console.WriteLine("Seating Arrangement:");
        for (int i = 0; i < seats.Length; i++)
        {
            string status = seats[i] ? "Available" : "Booked";
            Console.WriteLine($"Seat {i + 1}: {status}"); 
        }
        Console.WriteLine();
    }
    void BookSeat(bool[] seats, int seatNumber)
    {
        if (!seats[seatNumber])
        { 
            Console.WriteLine($"Warning: Seat {seatNumber + 1} is already booked.");
        }
        else
        {
            seats[seatNumber] = false; 
            Console.WriteLine($"Seat {seatNumber + 1} has been successfully booked.");
        }
    }

}

