using static System.Formats.Asn1.AsnWriter;

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
        Console.Write("Feedback: " + GetGradeFeedback(grade));


    }
    string CalculateGrade(int score)
    {
        if (score >= 90 && score <= 100)
        {
            return "A";
        }
        else if (score >= 80 && score <= 89)
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
            return "F";
        }
    }

    string GetGradeFeedback(string grade)
    {
        if (grade == "A")
        {
            return "Excellent work!";
        }
        else if (grade == "B")
        {
            return "Good job, but there’s room for improvement.";
        }
        else if (grade == "C")
        {
            return "You passed, but consider reviewing the material.";
        }
        else if (grade == "D")
        {
            return "Barely passed, you should work harder.";
        }
        else
        {
            return "Failed, please seek help.";
        }
    }
}

