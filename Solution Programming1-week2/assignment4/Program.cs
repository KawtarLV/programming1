namespace assignment4;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {

        Console.WriteLine("Enter the first number : ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number : ");
        int seconNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operation (+,-,*,/) ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "+":
                 Addition(firstNumber,seconNumber);
                break;
            case "-":
                Subtraction(firstNumber, seconNumber);
                break;
            case "*":
                Multiplication(firstNumber, seconNumber);
                break;
            case "/":
                Division(firstNumber, seconNumber);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }





    }

    void Addition(int firstNumber, int seconNumber)
    {
        int result = firstNumber + seconNumber;
         Console.WriteLine($"{firstNumber} + {seconNumber} = {result} ");

    }

    void Subtraction(int firstNumber, int seconNumber)
    {
        int result = firstNumber - seconNumber;
         Console.WriteLine($"{firstNumber} - {seconNumber} = {result} ");
        
    }

    void Multiplication(int firstNumber, int seconNumber)
    {
        int result = firstNumber * seconNumber;
        Console.WriteLine($"{firstNumber} * {seconNumber} = {result} ");
       
    }

    void Division(int firstNumber, int seconNumber)
    {
        if (seconNumber == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            int result = firstNumber / seconNumber;
            Console.WriteLine($"{firstNumber} / {seconNumber} = {result}");
        }
    }


}

