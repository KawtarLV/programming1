namespace assignment5;

class Program
{
    const int arraySize = 100;
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int[] numbers = new int[arraySize];
        ReadNumbers(numbers);

        Console.Write("Enter a value to search: ");
        int searchValue = int.Parse(Console.ReadLine());

        int occurrences = CountSearchValue(numbers, searchValue);

        Console.WriteLine($"The value {searchValue} occurs {occurrences}.");
    }

    void ReadNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter a number (0 to stop): ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            numbers[i] = number;

        }
    }

    int CountSearchValue(int[] numbers, int searchValue)
    {

        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchValue)
            {
                count++;
            }
        }
        return count;
    }
}