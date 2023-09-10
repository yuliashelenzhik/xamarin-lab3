using System;
using System.ComponentModel;

namespace lab3
{
	public class FlightSchedule
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string PlaneType { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }

    }
}

