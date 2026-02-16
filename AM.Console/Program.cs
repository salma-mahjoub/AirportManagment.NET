using System;
using System.Security.Cryptography.X509Certificates;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

namespace AM.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //PArite 1
            // Q7 : Constructeur non paramétré

            /*Plane p1 = new Plane();

            // Initialisation via les propriétés
            p1.PlaneId = 1;
            p1.Capacity = 180;
            p1.ManufactureDate = new DateTime(2019, 6, 15);
            p1.PlaneType = PlaneType.Airbus;

            System.Console.WriteLine("Plane 1:");
            System.Console.WriteLine(p1);

            // Initialisation via l'initialiseur d'objet    
            Plane p2 = new Plane
            {
                PlaneId = 1,
                Capacity = 180,
                ManufactureDate = new DateTime(2019, 6, 15),
                PlaneType = PlaneType.Airbus
            };

            // Q8 Constructeur paramétré
            Plane p3 = new Plane(PlaneType.Boing, 220, new DateTime(2015, 3, 20));
            p3.PlaneId = 2;

            System.Console.WriteLine("\nPlane 3:");
            System.Console.WriteLine(p3);*/

            //Partie 2
            /*Passenger p = new Passenger { FirstName = "John", LastName = "Doe", EmailAddress = "john.doe@mail.com" };
            Staff s = new Staff { FirstName = "Alice", LastName = "Smith", EmailAddress = "alice.smith@mail.com" };
            Traveller t = new Traveller { FirstName = "Bob", LastName = "Brown", EmailAddress = "bob.brown@mail.com" };

            // Test polymorphisme par héritage
            System.Console.WriteLine("=== PassengerType() Test ===");
            p.PassengerType();
            s.PassengerType();
            t.PassengerType();

            // Test polymorphisme par signature
            System.Console.WriteLine("\n=== CheckProfile() Test ===");
            System.Console.WriteLine(p.CheckProfile("John", "Doe")); // True
            System.Console.WriteLine(p.CheckProfile("John", "Doe", "john.doe@mail.com")); // True
            Passenger p2 = new Passenger { FirstName = "John", LastName = "Doe", EmailAddress = "john.doe@mail.com", BirthDate = new DateTime(1990, 1, 1) };
            System.Console.WriteLine(p.CheckProfile(p2)); */

            // Partie 2 -III
            // Création du service
             FlightMethods fm = new FlightMethods();
             fm.Flights = TestData.listFlights;

            // // 1. Dates des vols vers Paris (for)
            // var datesParis = fm.GetFlightDates("Paris");
            // System.Console.WriteLine("Flight dates to Paris (for):");
            // foreach (var date in datesParis)
            // {
            //     System.Console.WriteLine(date);
            // }

            // // 2. Dates des vols vers Paris (foreach)
            // var datesParis2 = fm.GetFlightDatesForeach("Paris");
            // System.Console.WriteLine("\nFlight dates to Paris (foreach):");
            // foreach (var date in datesParis2)
            // {
            //     System.Console.WriteLine(date);
            // }

            // // 3. Vols filtrés par destination
            // var flightsMadrid = fm.GetFlights("Destination", "Madrid");
            // System.Console.WriteLine("\nFlights to Madrid:");
            // foreach (var flight in flightsMadrid)
            // {
            //     System.Console.WriteLine($"{flight.FlightDate} - {flight.Destination} - {flight.EstimatedDuration} min");
            // }
             
            //Partie 3
            //I.
            //2.
            //fm.ShowFlightDetails(TestData.BoingPlane);

            //3.
            // DateTime startDate = new DateTime(2022, 1, 1);
            // int programmedFlights = fm.ProgrammedFlightNumber(startDate);
            // System.Console.WriteLine($"\nNumber of programmed flights after {startDate.ToShortDateString()}: {programmedFlights}");

            // 4.
            // string destination = "Lisbonne";
            // double averageDuration = fm.DurationAverage(destination);
            // System.Console.WriteLine($"\nLa durée moyenne des vols vers {destination} est de {averageDuration} minutes.");

            //5.
            // var orderedFlights = fm.OrderedDurationFlights();

            // System.Console.WriteLine("\nVols ordonnés par durée estimée (du plus long au plus court) :");

            // foreach (var flight in orderedFlights)
            // {
            //     System.Console.WriteLine($"Destination: {flight.Destination} | Date: {flight.FlightDate:dd/MM/yyyy} | Durée: {flight.EstimatedDuration} min");
            // }
            
            //6.
            // foreach(var p in fm.SeniorTravellers(TestData.flight1))
            // {
            //     System.Console.WriteLine(p);

            //Q7.
            var groupedFlights = fm.DestinationGroupedFlights();

            System.Console.WriteLine("\nVols groupés par destination :");

            foreach (var group in groupedFlights)
            {
                System.Console.WriteLine($"\nDestination : {group.Key}");

                foreach (var flight in group)
                {
                    System.Console.WriteLine($"Décollage {flight.FlightDate:dd/MM/yyyy HH:mm} : {flight.EstimatedDuration} min");
                }
            }


            // }
            //III.
            // Passenger passenger = new Passenger { FirstName = "salma", LastName = "mahjoub" };
            // passenger.UpperFullName();
            // System.Console.WriteLine($"\nPassenger full name in uppercase: {passenger.FirstName} {passenger.LastName}");


        }
            
        
    }
}
