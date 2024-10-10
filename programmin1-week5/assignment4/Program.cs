namespace assignment4;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter book author: ");
        string author = Console.ReadLine();

        
        Book myBook = new Book(title, author);

        
        Console.WriteLine("Book Information:");
        myBook.DisplayBookInfo();
    }
}

