using System;
namespace assignment13
{
	public class EventScheduler
	{
		Event[] events;
		private int IndexEvent=0;

		public EventScheduler(int capacity)
		{
			events = new Event[capacity];
		}

        public void AddEvent(Event @event)
		{
			if (IndexEvent < events.Length)
			{
				events[IndexEvent]= @event;
				IndexEvent++;
			}
			Console.WriteLine("\nEvent added to scheduler");
		}

		public void DisplayEvents()
		{
            Console.WriteLine("\nScheduled Events:");
			for (int i = 0; i < IndexEvent; i++)
				Console.WriteLine($"{events[i].EventName} on {events[i].Date} at {events[i].Location}");

        }

    }
}

