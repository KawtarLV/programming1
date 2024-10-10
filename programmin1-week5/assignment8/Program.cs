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

        Console.Write("How many books should there be in the library: ");
        int BooksCount = int.Parse(Console.ReadLine());

        Library library = new Library(BooksCount);

        while (library.Count < BooksCount)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter book author: ");
            string author = Console.ReadLine();

            Book myBook = new Book(title, author);
            library.AddBook(myBook);
        }

        Console.WriteLine("Books in library:");
        library.DisplayBooks();
    }
}

