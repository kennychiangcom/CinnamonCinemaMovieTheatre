using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public DateTime DateTime { get; set; }
        public int SeatId { get; set; }
        public float Price { get; set; }

    }
}
