using System;
namespace assignment12
{
	public class TrafficLightSimulator
	{

        private TrafficLight currentLight;

        public TrafficLightSimulator()
		{
			currentLight = TrafficLight.red;
		}

		public void SetLight(TrafficLight light)
		{
            currentLight = light;
		}

		public void DisplayCurrentLight()
		{
			if (currentLight == TrafficLight.green)
				Console.ForegroundColor = ConsoleColor.Green;
			else if(currentLight == TrafficLight.red)
                Console.ForegroundColor = ConsoleColor.Red;
			else if(currentLight == TrafficLight.yellow)
                Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Current traffic light: {currentLight}");
			Console.ResetColor();
		}
    }

}

