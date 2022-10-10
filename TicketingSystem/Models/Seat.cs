using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public string Row { get; set; }
        public string Col { get; set; }
        public Type Type { get; set; }
    }
}
