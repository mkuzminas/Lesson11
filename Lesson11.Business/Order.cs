using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class Order
    {
        public int Id { get; }
        public DateTime DateTime { get; }
        public Aircraft Aircraft { get; }
        
        public Order(int id, Aircraft aircraft)
        {
            Id = id;
            DateTime = DateTime.Now;
            Aircraft = aircraft;
        }
    }
}
