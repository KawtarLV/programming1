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
        Console.Write("Enter the start integer: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the end integer: ");
        int end = int.Parse(Console.ReadLine());

        (int evenCount, int oddCount) = CountEvenAndOdd(start, end);

        Console.WriteLine($"Even numbers count: {evenCount}");
        Console.WriteLine($"Odd numbers count: {oddCount}");
    }

    (int evenCount, int oddCount) CountEvenAndOdd(int start, int end)
    {
        int evenCount = 0;
        int oddCount = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                evenCount++; 
            }
            else
            {
                oddCount++;
            }
        }
        return (evenCount, oddCount);
    }
}


