namespace Assignment3;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.Write("Enter an integer: ");
        int userInput = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication table of {userInput}:");
        PrintMultiplicationTable(userInput);
    }
    void PrintMultiplicationTable(int number)
    {
        int i = 1;
        while (i<= 10)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
            i++;
        }
    }
}

