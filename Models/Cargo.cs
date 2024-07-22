using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApp.Models
{
    public class Cargo
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }

        public Cargo(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
