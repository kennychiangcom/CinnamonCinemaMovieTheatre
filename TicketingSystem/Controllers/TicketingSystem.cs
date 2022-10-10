using TicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Controllers
{
    public class TicketingSystemController
    {
        public int GetTicket(int[] requests)
        {
            return CheckAvailabileSeat();
        }
        public int CheckAvailabileSeat()
        {
            return 2;
        }
        public int CustomerRequest()
        {
            return 3;
        }
    }
}
