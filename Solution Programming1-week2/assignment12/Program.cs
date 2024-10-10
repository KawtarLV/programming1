using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace assignment12;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        Console.Write("Enter the first side : ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second side : ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third side : ");
        int side3 = int.Parse(Console.ReadLine());

        DetermineTriangleType(side1,side2,side3);

    }

    void DetermineTriangleType(int side1, int side2, int side3)
    {
        if (side1 == side2 && side1 == side3)
        {
            Console.WriteLine("The triangle is Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is Isosceles");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene");
        }
    }
}

