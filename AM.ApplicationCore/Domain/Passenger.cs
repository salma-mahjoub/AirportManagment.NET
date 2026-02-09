using System;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public int TelNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, TelNumber: {TelNumber}";
        }

        // 1a. Vérification par Nom et Prénom
        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }

        // 1b. Vérification par Nom, Prénom et Email
        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
        }

        // 1c. Méthode "remplaçante" pour tout vérifier
        public bool CheckProfile(Passenger other)
        {
            return FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   EmailAddress == other.EmailAddress &&
             
                   BirthDate == other.BirthDate;
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

    }
}
