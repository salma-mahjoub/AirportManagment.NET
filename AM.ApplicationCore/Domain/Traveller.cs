namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string Nationality { get; set; }
        public string HealthInformation { get; set; }

        public override string ToString()
        {
            return $"Nationality: {Nationality}, HealthInformation: {HealthInformation}, {base.ToString()}";
        }
        public override void PassengerType()
        {
            base.PassengerType(); // Appelle la méthode de la classe mère
            Console.WriteLine("I am a Traveller");
        }

    }

    
}
