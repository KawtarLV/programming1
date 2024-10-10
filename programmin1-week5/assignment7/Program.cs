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
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter amount of grades to process: ");
        int gradesCount = int.Parse(Console.ReadLine());

        int[] Grades = new int[gradesCount];

        for(int i =0; i<gradesCount; i++)
        {
            Console.Write($"Enter grade {i+1} :");
            Grades[i] = int.Parse(Console.ReadLine());
        }

        Student student = new Student(studentName, Grades);

        student.DisplayGrades();

        double Average = student.CalculateAverage();
        Console.WriteLine($"Average Grade: {Average:F2}"); 

    }
}

