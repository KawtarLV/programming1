namespace assignment11;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        EmployeeManager employeeManager = new EmployeeManager(1);

        Console.Write("Enter employee name: ");
        string Name = Console.ReadLine();

        Console.Write("Enter employee ID: ");
        int ID = int.Parse(Console.ReadLine());

        Console.Write("Enter employee salary: ");
        double Salary = double.Parse(Console.ReadLine());

        employeeManager.AddEmployee(new Employee(Name, ID, Salary));
        employeeManager.DisplayEmployees();
        employeeManager.CalculateAverageSalary();
        Console.ReadKey();
    }
}

