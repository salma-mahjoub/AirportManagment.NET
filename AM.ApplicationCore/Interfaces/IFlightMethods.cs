using AM.ApplicationCore.Domain;
using System.Collections.Generic;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        public List<Flight> Flights { get; set; }

        // Signature des méthodes (à compléter plus tard)
        public IEnumerable<DateTime> GetFlightDates(string destination);
        public List<Flight> GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);

        public int ProgrammedFlightNumber(DateTime startDate);

        public IEnumerable<Traveller> SeniorTravellers(Flight flight);

        
    }
}
