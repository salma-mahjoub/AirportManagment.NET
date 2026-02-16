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
            // List<DateTime> dates = new List<DateTime>();

            // for (int i = 0; i < Flights.Count; i++)
            // {
            //     if (Flights[i].Destination == destination)
            //     {
            //         dates.Add(Flights[i].FlightDate);
            //     }
            // }

            // return dates;
            return Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();
        }


        public List<DateTime> GetFlightDatesForeach(string destination)
        {
            // List<DateTime> dates = new List<DateTime>();

            // foreach (var flight in Flights)
            // {
            //     if (flight.Destination == destination)
            //     {
            //         dates.Add(flight.FlightDate);
            //     }
            // }

            // return dates;
            return Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();
        }
        public List<DateTime> GetFlightDatesLink(string destination)
        {
            // List<DateTime> dates = new List<DateTime>();

            // var query = from flight in Flights
            //             where flight.Destination == destination
            //             select flight.FlightDate;
            // return query.ToList();
            //Méthode avec lambda
            return Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).ToList();

        }
        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            // List<Flight> filteredFlights = new List<Flight>();

            // foreach (var flight in Flights)
            // {
            //     switch (filterType)
            //     {
            //         case "Destination":
            //             if (flight.Destination == filterValue)
            //                 filteredFlights.Add(flight);
            //             break;
            //         case "EstimatedDuration":
            //             if (flight.EstimatedDuration.ToString() == filterValue)
            //                 filteredFlights.Add(flight);
            //             break;
            //         case "FlightDate":
            //             if (flight.FlightDate.ToString("dd/MM/yyyy") == filterValue)
            //                 filteredFlights.Add(flight);
            //             break;
            //         // tu peux ajouter d'autres filtres simples si nécessaire
            //         default:
            //             Console.WriteLine("Filter type not recognized");
            //             break;
            //     }
            // }

            // return filteredFlights;
            return Flights.Where(f =>
                (filterType == "Destination" && f.Destination == filterValue) ||
                (filterType == "EstimatedDuration" && f.EstimatedDuration.ToString() == filterValue) ||
                (filterType == "FlightDate" && f.FlightDate.ToString("dd/MM/yyyy") == filterValue)
            ).ToList();
        }
        public void ShowFlightDetails(Plane plane)
        {
            // var query = from flight in Flights
            //             where flight.Plane == plane
            //             select new { flight.FlightDate, flight.Destination }; //Type anonyme , structure de données temporaire pour stocker les résultats
            //             foreach (var item in query)
            //             {         
            //                 Console.WriteLine($"Flight to {item.Destination} on {item.FlightDate}");   
            //             }
            //Méthode avec lambda
            Flights.Where(f => f.Plane == plane)
                   .Select(f => new { f.FlightDate, f.Destination })
                   .ToList()
                   .ForEach(item => Console.WriteLine($"Flight to {item.Destination} on {item.FlightDate}"));
        }
        //Méthode 1
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            // var query = from flight in Flights
            //             where flight.FlightDate >= startDate
            //             && flight.FlightDate <= startDate.AddDays(7)
            //             select flight;

            // return query.Count();
            return Flights.Count(flight => flight.FlightDate >= startDate && flight.FlightDate <= startDate.AddDays(7));
        }
        //Méthode 2
        public int ProgrammedFlightNumberWithCompare(DateTime startDate)
        {

            // var query = from flight in Flights
            //             where DateTime.Compare(flight.FlightDate, startDate) >= 0
            //             && (flight.FlightDate - startDate).TotalDays <= 7   
            //             select flight;

            // return query.Count();
            return Flights.Count(flight => DateTime.Compare(flight.FlightDate, startDate) >= 0 && (flight.FlightDate - startDate).TotalDays <= 7);
        }
        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            // var query = from p in flight.Passengers.OfType<Traveller>()
            // orderby p.BirthDate 
            // select p;
            // return query.Take(3);
            return flight.Passengers.OfType<Traveller>().OrderBy(p => p.BirthDate).Take(3);
        }
        //Q4
        public double DurationAverage(string destination)
        {
            return Flights
                .Where(f => f.Destination == destination)
                .Select(f => f.EstimatedDuration)
                .DefaultIfEmpty(0)  
                .Average();
        }
        //Q5
        public List<Flight> OrderedDurationFlights()
        {
            return Flights
                .OrderByDescending(f => f.EstimatedDuration)
                .ToList();
        }
        //Q7
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            return Flights.GroupBy(f => f.Destination);
        }







    }
}
