using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Business
{
    public class AirCraft
    {
        public int TailNumber { get; }
        public Model Model { get; }
        public Company Owner { get; }

        public AirCraft(int tailNumber, Model model, Company owner)
        {
            TailNumber = tailNumber;
            Model = model;
            Owner = owner;
        }
    }
}
