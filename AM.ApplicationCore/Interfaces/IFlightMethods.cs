using AM.ApplicationCore.Domain;
using System.Collections.Generic;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        public List<Flight> Flights { get; set; }

        public IEnumerable<DateTime> GetFlightDates(string destination);
        public List<Flight> GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);

        public int ProgrammedFlightNumber(DateTime startDate);

        public IEnumerable<Traveller> SeniorTravellers(Flight flight);

        //Q4
        public double DurationAverage(string destination);

        //Q5
        public List<Flight> OrderedDurationFlights();

        //Q7
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();


        
    }
}
