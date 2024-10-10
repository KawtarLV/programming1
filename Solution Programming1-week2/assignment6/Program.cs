namespace assignment6;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter your score (0-100) : ");
        int score = int.Parse(Console.ReadLine());

        string grade = CalculateGrade(score);
        Console.WriteLine($"Your grade is : {grade}");


    }
    string CalculateGrade(int score)
    {
        if (score>=90 && score <= 100 )
        {
            return "A";
        }
        else if(score >= 80 && score <= 89)
        {
            return "B";
        }

        else if (score >= 70 && score <= 79)
        {
            return "C";
        }
        else if (score >= 60 && score <= 69)
        {
            return "D";
        }
        else 
        {
            return  "F";
        }
    }
}

