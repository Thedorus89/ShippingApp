using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApp.Models
{
    public class Ship
    {
        public string Name { get; private set; }
        public double MaxCargoWeight { get; private set; }
        public double CurrentCargoWeight;
        public List<Cargo> CargoList;

        public Ship(string name, double maxCargoWeight)
        {
            Name = name;
            MaxCargoWeight = maxCargoWeight;
            CurrentCargoWeight = 0;
            CargoList = new List<Cargo>();
        }

    }
}
