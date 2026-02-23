using System;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        //public int Id { get; set; }
        [MinLength(3, ErrorMessage = "First name must be at least 3 characters long.")]
        [MaxLength(25, ErrorMessage = "First name cannot be longer than 25 characters.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7,ErrorMessage = "Passport number must be 7 characters long.")]
        public string PassportNumber { get; set; }
        
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        [RegularExpression(@"^\d{8}$", ErrorMessage = "TelNumber must contain exactly 8 digits")] // ou "[0-9]{8}$"
        public int TelNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, TelNumber: {TelNumber}";
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
