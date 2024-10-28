using System;
namespace assignment10
{
	public class Quiz
	{
        private Question[] questions;
        private int questionIndex = 0;
        private int score = 0; 
        public Quiz(int numberOfQuestions)
		{
            questions = new Question[numberOfQuestions];
		}

        public void AddQuestion(Question question)
		{
			if (questionIndex < questions.Length)
			{
				questions[questionIndex] = question;
				questionIndex++;
			}
		}

        public void TakeQuiz()
		{
			for(int i=0; i< questions.Length; i++)
			{
				Console.WriteLine($"Question {i+1}: {questions[i].QuestionText}");
				for(int j = 0; j< questions[i].Options.Length; j++)
				{
					Console.WriteLine($"{j+1}. {questions[i].Options[j]}");
				}

                Console.Write("Enter your answer (1-4): ");
				int useAnswer = int.Parse(Console.ReadLine()) - 1;

				if(useAnswer== questions[i].CorrectAnswerIndex)
				{
					score++;
				}
             }
		}

		public void DisplayResults()
		{
			Console.Write($"Your score: {score}/{questionIndex}");
		}
    }
}

