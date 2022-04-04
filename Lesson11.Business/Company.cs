using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class Company
    {
        public string Name { get; }
        public Country Country { get; }

        public Company(string name, Country Country)
        {
            Name = name;
            Country = Country;
        }
    }
}
