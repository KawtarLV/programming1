namespace assignment1;

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

    }

    void FillArray(int[] numbers)
    {
        Random random = new Random();

        for (int i = 1; i < numbers.Length; i++)
             numbers[i] = random.Next(1,101);
    }

    void DisplayArray(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
            Console.WriteLine($"Element { i }: {numbers[i]}");
    }

}

