using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public int id { get; set; }
        public string  Classe { get; set; }
        public string Destination { get; set; }

        public virtual ICollection<ReservationTicket> Reservations { get; set; }


    }
}
