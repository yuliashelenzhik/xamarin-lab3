using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace lab3.VM
{
	public class FlightViewModel
	{

        public ObservableCollection<FlightSchedule> Flights { get; set; } = new ObservableCollection<FlightSchedule>();

        public void LoadData()
        {

            Flights.Add(new FlightSchedule { FlightNumber = "ABC123", PlaneType = "Boeing 737", Destination = "New York", DepartureTime = DateTime.Parse("2023-09-07 10:00:00") });
            Flights.Add(new FlightSchedule { FlightNumber = "XYZ456", PlaneType = "Airbus A320", Destination = "Paris", DepartureTime = DateTime.Parse("2023-09-07 11:30:00") });
            Flights.Add(new FlightSchedule { FlightNumber = "DL738", PlaneType = "Airbus A320", Destination = "Berlin", DepartureTime = DateTime.Parse("2023-09-07 17:57:00") });
        }

        public IEnumerable<FlightSchedule> GetFlightsForDestination(string destination)
        {
            return Flights.Where(f => f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                          .OrderBy(f => f.DepartureTime);
        }


    }
}

