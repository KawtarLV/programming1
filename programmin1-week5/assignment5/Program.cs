namespace assignment5;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
    void Start()
    {
        Person[] persons = new Person[3];

        for (int i =0;i<persons.Length; i++)
        {
            Console.WriteLine($"Enter the name of person {i + 1}:");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter the age of person {i + 1}:");
            int age = int.Parse(Console.ReadLine());

            persons[i] = new Person(name, age);
        }
        PrintPersonArray(persons);
    }
    static void PrintPersonArray(Person[] persons)
    {
        Console.WriteLine("Displaying all persons:");
        for (int i = 0; i < persons.Length; i++)
        {
            // ...
            persons[i].DisplayPersonInfo(i);
        }
    }
}

