namespace assignment3;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();

    }


    void Start()
    {

        Console.Write("Please enter a number : ");
        int userInput = int.Parse(Console.ReadLine());
        string result = CheckNumber(userInput);

        Console.WriteLine($"The number is {result}");

    }


    string CheckNumber(int num)
    {
        string status;
        if(num < 0)
        {
            status = "negative";
        }
        else if(num > 0)
        {
            status = "positive";
        }
        else
        {
            status = "zero";
        }
        return status;

    }
}