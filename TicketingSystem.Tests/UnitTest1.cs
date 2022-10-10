using TicketingSystem.Models;
using TicketingSystem.Controllers;
using NUnit.Framework;

namespace TicketingSystem.Tests
{
    public class TicketingSystemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // ARRANGE
            int expectedTicketsLeft = 2;
            var _controller = new TicketingSystemController();

            // ACT
            int[] ticketRequests = {1,3,2,3,3,1};
            var result = _controller.GetTicket(ticketRequests);
        
            // ASSERT
            Assert.That(expectedTicketsLeft, Is.EqualTo(result));
        }
    }
}
