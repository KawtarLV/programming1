using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace assignment1;

class Program
{
    static void Main(string[] args)
    {
        //read the age
        Console.Write("Please enter your age :");
        string input = Console.ReadLine();


        //check if hte input a number
        bool isSuccess = int.TryParse(input, out int result);


        if (isSuccess)
        {
            if (result <= 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else
            {
                Console.WriteLine("You are an adult.");
            }

        }
        else
        {
            Console.WriteLine("Failed.try again.");
        }
    }
}

