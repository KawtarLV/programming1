namespace assignment1;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.Write("Enter a positive integer: ");
        int userInput = int.Parse(Console.ReadLine());

        int sum = CalculateSum(userInput);

        Console.WriteLine($"The sum of natural numbers from 1 to {userInput} is: {sum}");
    }
    int CalculateSum(int n)
    {
        int sum = 0;
        for(int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}

