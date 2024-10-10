using System;

namespace assignment2;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();

    }
    void Start()
    {

        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine($"{number} is an even number.");

        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }

    }
    bool IsEven(int num)
    {
        return num % 2 == 0;

    }
}

