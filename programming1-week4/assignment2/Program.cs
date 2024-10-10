namespace assignment2;

class Program
{
    const int ArraySize = 20;
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int[] numbers = new int[ArraySize];
        FillArray(numbers);
        DisplayArray(numbers);

        int SmallestNumber = GetSmallestNumber(numbers);
        Console.WriteLine($"Smallest number is: {SmallestNumber}");
    }

    void FillArray(int[] numbers)
    {
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = random.Next(1, 101);
    }

    void DisplayArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
            Console.Write($"{numbers[i]} ");
    }

    int GetSmallestNumber(int[] numbers)
    {
        int smallestNumber = numbers[0];
        for(int i=1; i<numbers.Length; i++)
        {
            
            if (numbers[i] < smallestNumber)
                smallestNumber = numbers[i];

        }

        return smallestNumber;
    }
}





