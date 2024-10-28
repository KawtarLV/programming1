using System;
namespace assignment10
{
	public class Question
	{
		public string QuestionText { get; private set; }
        public string[] Options { get; private set; }
        public int CorrectAnswerIndex { get; private set; }

        public Question(string questionText, string[] options, int correctAnswerIndex)
		{
			QuestionText = questionText;
			Options = options;
			CorrectAnswerIndex = correctAnswerIndex;

        }

       


    }
}

