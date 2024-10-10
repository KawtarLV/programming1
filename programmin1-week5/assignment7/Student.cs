using System;
namespace assignment7
{
	public class Student
	{
        public string StudentName { set; get; }
        public int[] Grades;
        
        public Student(string studentName, int[] grades)
		{
            Grades = grades;
			StudentName = studentName;
		}

		public double CalculateAverage()
		{
			int total = 0;

			foreach(int grade in Grades)
			{
				total += grade;
			}

			return (double)total / Grades.Length;
		}

		public void DisplayGrades()
		{ 

           Console.WriteLine($"Grades for {StudentName}:");

            for (int i = 0; i < Grades.Length; i++)
            {
                if (i == Grades.Length - 1)
                {
                    Console.Write(Grades[i]);
                }
                else
                {
                    Console.Write(Grades[i] + ", ");
                }
            }
            Console.WriteLine();
        }

    }
}

