namespace assignment12;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        TrafficLightSimulator trafficLightSimulator = new TrafficLightSimulator();
        trafficLightSimulator.DisplayCurrentLight();

        Console.WriteLine("Changing light to Yellow...");
        trafficLightSimulator.SetLight(TrafficLight.yellow);
        trafficLightSimulator.DisplayCurrentLight();

        Console.WriteLine("Changing light to Green...");
        trafficLightSimulator.SetLight(TrafficLight.green);
        trafficLightSimulator.DisplayCurrentLight();



        Console.ReadKey();
    }
}

