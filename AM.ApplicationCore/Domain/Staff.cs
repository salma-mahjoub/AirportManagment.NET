using System;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"EmploymentDate: {EmploymentDate}, Function: {Function}, Salary: {Salary}, {base.ToString()}";
        }
        public override void PassengerType()
        {
            base.PassengerType(); // Appelle la méthode de la classe mère
            Console.WriteLine("I am a Staff Member");
        }

    }
}
