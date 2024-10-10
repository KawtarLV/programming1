namespace assignment7;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter Dimension size: ");
        int dimensionSize = int.Parse(Console.ReadLine());

        PrintSquare(dimensionSize);
    }

    void PrintSquare(int dimensionSize)
    {
        for (int i = 1; i <= dimensionSize; i++)
        {
            for (int j = 1; j <= dimensionSize; j++)
            {
                if (i == 1 || i == dimensionSize || j == 1 || j == dimensionSize)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

