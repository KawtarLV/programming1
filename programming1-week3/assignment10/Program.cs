namespace assignment10;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.Write("Enter an integer to reverse: ");
        int number = int.Parse(Console.ReadLine());
        int reversed = ReversedNumber(number);

        Console.WriteLine($"Reversed number: {reversed}");

    }

    static int ReversedNumber(int number)
    {

        int reversed = 0;
        while (number != 0)
        {
            int lastDigit = number % 10; 
            reversed = reversed * 10 + lastDigit; 
            number /= 10; 
        }
        return reversed;
    }
}

