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
        int[] numbers = new int[3];

        Console.WriteLine("Enter 3 integers:");
        for (int i=0;i<= numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = CalculateSum(numbers);
        double average = CalculateAverage(numbers, sum); 


        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
    }

    int CalculateSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    double CalculateAverage(int[] numbers, int sum)
    {
        return (double)sum / numbers.Length; 
    }
}
