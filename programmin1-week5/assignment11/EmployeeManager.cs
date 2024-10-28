using System;
namespace assignment11
{
	public class EmployeeManager
	{
		private Employee[] employees;
        private int employeeIndex = 0;
		private double totalSalary=0;

        public EmployeeManager(int capacity)
		{
			employees = new Employee[capacity];
		}

		public void AddEmployee(Employee employee)
		{
			if(employeeIndex < employees.Length)
			{
				employees[employeeIndex] = employee;
				Console.WriteLine("\nEmployee added.");
                employeeIndex++;
            }

		}

		public void CalculateAverageSalary()
		{
            for (int i = 0; i < employeeIndex; i++)
			{
				totalSalary += employees[i].Salary;

            }

			Console.WriteLine($"\nAverage Salary:{totalSalary / employees.Length}");
		}

        public void DisplayEmployees()
		{
			Console.WriteLine("\nEmployee Details:");
            for (int i = 0; i < employeeIndex; i++)
            {
                Console.WriteLine($"Name: {employees[i].Name}\nID: {employees[i].ID}\nSalary: {employees[i].Salary}");
            }
        }
    }
}

