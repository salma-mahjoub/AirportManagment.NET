using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket 
    {
        public DateTime  DateReservation { get; set; }
        public float Prix { get; set; }
        
        [ForeignKey("passenger")]
        public string FkPassenger { get; set; }
        [ForeignKey("ticket")]
        public int FkTicket { get; set; }
        public virtual Passenger passenger { get; set; }
        public virtual Ticket ticket { get; set; } 
    }
}
