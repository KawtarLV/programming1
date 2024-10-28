namespace assignment10;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Quiz quiz = new Quiz(1);

        // Adding sample questions
        quiz.AddQuestion(new Question("What is the capital of France?", new string[] { "Berlin", "Madrid", "Paris", "Rome" }, 2));

        quiz.TakeQuiz();
        quiz.DisplayResults();
        Console.ReadKey();
    }
}

