namespace assignment6;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.Write("Enter a positive integer greater than 1: ");
        int userInput = int.Parse(Console.ReadLine());

        if (IsPrime(userInput))
            Console.WriteLine($"{userInput} is a prime number.");      
        else
            Console.WriteLine($"{userInput} is not a prime number.");
        

    }
    bool IsPrime(int number)
    {
        int i = 2;
        while (i < number)
        {
            if ( number % i == 0)
                return false;
            else
                i++;
        }
        return true;
    }
}

