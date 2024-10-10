using System;
using System.Reflection;

namespace assignment5
{
	public class Person
	{
		public string Name;
		public int Age;

		public Person(string Name , int Age)
		{
			this.Name = Name;
			this.Age = Age;

		}
        public void DisplayPersonInfo(int index)
        {
            Console.WriteLine($"Person {index + 1}:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}\n");
        }
    }
}

