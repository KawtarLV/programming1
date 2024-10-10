namespace assignment3;

class Program
{
    const int ArraySize = 3;

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int[] numbers = new int[ArraySize];
        Console.WriteLine($"Enter {ArraySize} integers: ");
        FillArray(numbers);
        int sum = CalculateSum(numbers);
        double average = CalculateAverage(numbers);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");


    }

    void FillArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
    }

    int CalculateSum(int[] numbers)
    {
        int sum=0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i]; 
        }
        return sum;
    }
    double CalculateAverage(int[] numbers)
    {
        int sum = CalculateSum(numbers); 
        return (double)sum / numbers.Length;
    }

}
