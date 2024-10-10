namespace assignment5;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int largest = FindMax(num1, num2, num3);
        Console.WriteLine($"The largest number is: {largest}");


    }

    int FindMax(int num1,int num2,int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            return num1;
        }
        else if (num2> num1 && num2>num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }

    }

}

