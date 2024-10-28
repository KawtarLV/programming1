using System;
namespace assignment11
{
	public class Employee
	{
        public string Name { get; private set; }
        public int ID { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name, int id, double salary)
		{
			Name = name;
			ID = id;
			Salary = salary;
		}
	}
}

