namespace assignment8;
class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter the number of elements: ");
        int count = int.Parse(Console.ReadLine());


        int sum = CalculateSum(count);
        double average = CalculateAverage(sum, count);


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average:F1}");

    }

        int CalculateSum(int count)
        {
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            return sum;
        }

        double CalculateAverage(int sum, int count)
        {
            return (double)sum / count; //using double to ensure: produces a floating-point result 
        }
    
}
