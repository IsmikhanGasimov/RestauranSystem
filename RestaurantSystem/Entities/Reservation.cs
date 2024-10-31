using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumGuests { get; set; }
        public Customer Customer { get; set; }
    }
}
