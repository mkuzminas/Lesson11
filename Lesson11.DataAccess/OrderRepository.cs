using Lesson11.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.DataAccess
{
    internal class OrderRepository
    {
        private List<Order> orders { get; }

        public OrderRepository()
        {
            orders = new List<Order>();

            AircraftRepository aircraftRepository = new AircraftRepository();
            List<Aircraft> aircraft = aircraftRepository.Retrieve();

            orders.Add(new Order(1, aircraft[0]));
            orders.Add(new Order(2, aircraft[1]));
        }

        public List<Order> Retrieve()
        {
            return orders;
        }
    }
}
