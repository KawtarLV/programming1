namespace assignment1;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height:");
        double height = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(height,width);

       double area = rectangle.CalculateArea();
       double perimeter = rectangle.CalculatePerimeter();

        Console.WriteLine($"Area : {area}");
        Console.WriteLine($"Perimeter : {perimeter}");
    }
}

