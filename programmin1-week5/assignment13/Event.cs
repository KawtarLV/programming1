using System;
namespace assignment13
{
	public class Event
	{
		public string EventName { get; private set; }
        public string Date { get; private set; }
        public string Location { get; private set; }

        public Event(string eventName, string date, string location)
		{
			EventName = eventName;
			Date = date;
			Location = location;
		}


	}
}

