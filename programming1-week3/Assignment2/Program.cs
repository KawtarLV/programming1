namespace Assignment2;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.Write("Enter a non-negative integer ");
        int userInput = int.Parse(Console.ReadLine());

        int factorial = CalculateFactorial(userInput);

        Console.WriteLine($"The factorial of {userInput} is: {factorial}");
    }
    int CalculateFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

