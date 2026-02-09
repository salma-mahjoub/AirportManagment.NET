using AM.ApplicationCore.Domain;
using System.Collections.Generic;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        List<Flight> Flights { get; set; }

        // Signature des méthodes (à compléter plus tard)
        public IEnumerable<DateTime> GetFlightDates(string destination);
        List<Flight> GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
    }
}
