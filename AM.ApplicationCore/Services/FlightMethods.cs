using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public IEnumerable<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }
            }

            return dates;
        }


        public List<DateTime> GetFlightDatesForeach(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    dates.Add(flight.FlightDate);
                }
            }

            return dates;
        }
        public List<DateTime> GetFlightDatesLink(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            var query = from flight in Flights
                        where flight.Destination == destination
                        select flight.FlightDate;
            return query.ToList();
        }
        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            List<Flight> filteredFlights = new List<Flight>();

            foreach (var flight in Flights)
            {
                switch (filterType)
                {
                    case "Destination":
                        if (flight.Destination == filterValue)
                            filteredFlights.Add(flight);
                        break;
                    case "EstimatedDuration":
                        if (flight.EstimatedDuration.ToString() == filterValue)
                            filteredFlights.Add(flight);
                        break;
                    case "FlightDate":
                        if (flight.FlightDate.ToString("dd/MM/yyyy") == filterValue)
                            filteredFlights.Add(flight);
                        break;
                    // tu peux ajouter d'autres filtres simples si nécessaire
                    default:
                        Console.WriteLine("Filter type not recognized");
                        break;
                }
            }

            return filteredFlights;
        }
        public void ShowFlightDetails(Plane plane)
        {
            var query = from flight in Flights
                        where flight.Plane == plane
                        select new { flight.FlightDate, flight.Destination }; //Type anonyme , structure de données temporaire pour stocker les résultats
                        foreach (var item in query)
                        {         
                            Console.WriteLine($"Flight to {item.Destination} on {item.FlightDate}");   
                        }
        }


    }
}
