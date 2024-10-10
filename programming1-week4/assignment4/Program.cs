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
        Console.WriteLine("Enter course name: ");
        string coursName = Console.ReadLine();

        Console.WriteLine("Enter number of student ");
        int StudentsNumber = int.Parse(Console.ReadLine());

        string[] names = new string[StudentsNumber];
        int[] grades = new int[StudentsNumber];

        ReadNames(names);
        ReadGrades(grades, names);

        int highestGradeIndex = GetHighestGradeIndex(grades);

        Console.WriteLine($"Student  {names[highestGradeIndex]} has the highest grade: {grades[highestGradeIndex]}.");



    }
    void ReadNames(string[] names )
    {
       for(int i = 0; i<names.Length; i++)
        {
            Console.WriteLine($"Enter name of studen {i+1}");
            names[i] = Console.ReadLine();
        }
    }
    void ReadGrades(int[] grades, string[] names)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"EEnter grade of  {names[i]}");
            grades[i] = int.Parse(Console.ReadLine());
        }
    }
    int GetHighestGradeIndex(int[] grades)
    {
        int highestGradeIndex = 0;
        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > grades[highestGradeIndex])
            {
                highestGradeIndex = i; 
            }
        }
        return highestGradeIndex;
    }
}