namespace Assignments8;

class Program
{
    
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int numberOfAlbums = 0;
        string[] albums = new string[100];

        while (true)
        {
            Console.WriteLine("\nYour favorite albums are:");
            DisplayAlbums(albums, numberOfAlbums);

            Console.Write("Do you want to add another album? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response == "yes")
            {
                if (numberOfAlbums < albums.Length)
                {
                    Console.Write($"Enter the name of album {numberOfAlbums + 1}: "); // Updated prompt
                    albums[numberOfAlbums] = Console.ReadLine();
                    numberOfAlbums++;
                }
                else
                {
                    Console.WriteLine("Album storage is full. Cannot store more albums.");
                }
            }
            else if (response == "no")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid response. Please answer 'yes' or 'no'.");
            }
        }
        Console.Write("\nEnter the name of the album you want to search for: ");
        string searchAlbum = Console.ReadLine();

        if (FindAlbum(albums, numberOfAlbums, searchAlbum))
        {
            Console.WriteLine($"The album \"{searchAlbum}\" is in your list!");
        }
        else
        {
            Console.WriteLine($"The album \"{searchAlbum}\" is not in your list.");
        }
    }
    void DisplayAlbums(string[] albums, int numberOfAlbums)
    {
            for (int i = 0; i < numberOfAlbums; i++)
            {
              Console.WriteLine($"{i + 1}. {albums[i]}");
             }
     }
    bool FindAlbum(string[] albums, int numberOfAlbums, string searchAlbum)
    {
        for (int i = 0; i < numberOfAlbums; i++)
        {
           
            if (albums[i].ToLower() == searchAlbum.ToLower())
            {
                return true; 
            }
        }
        return false;

    }
}

