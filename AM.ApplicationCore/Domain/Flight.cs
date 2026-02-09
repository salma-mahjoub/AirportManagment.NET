using System;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        public Plane Plane { get; set; }

        public ICollection<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return $"FlightId: {FlightId}, Departure: {Departure}, Destination: {Destination}, FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimatedDuration}, Plane: [{Plane}]";
        }

    }
}
