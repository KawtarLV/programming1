namespace assignment9;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter the number of terms : ");
        int terms = int.Parse(Console.ReadLine());

        GenerateFibonacci(terms);

    }
    void GenerateFibonacci(int terms)
    {
        
        int firstNumber = 1;
        int secondNumber = 1;

     
        if (terms == 1)
        {
            Console.WriteLine("Fibonacci sequence:");
            Console.WriteLine(firstNumber);
            return;
        }
        if (terms == 2)
        {
            Console.WriteLine("Fibonacci sequence:");
            Console.WriteLine($"{firstNumber} {secondNumber}");
            return;
        }

        Console.WriteLine("Fibonacci sequence:");
        Console.Write($"{firstNumber} {secondNumber}");


        for (int i = 3; i <= terms; i++)
        {
            int nextNumber = firstNumber + secondNumber;
            Console.Write($" {nextNumber}");
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }

        Console.WriteLine(); 
    }

}

