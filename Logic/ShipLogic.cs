using ShippingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApp.Logic
{
    public class ShipLogic
    {
        private Ship _ship;

        public ShipLogic(Ship ship)
        {
            _ship = ship;
        }

        public bool LoadCargo(string cargoName, double weight)
        {
            if (_ship.CurrentCargoWeight + weight <= _ship.MaxCargoWeight)
            {
                _ship.CargoList.Add(new Cargo(cargoName, weight));
                _ship.CurrentCargoWeight += weight;
                Console.WriteLine($"Cargo '{cargoName}' with weight {weight} loaded successfully.");
                return true;
            }
            else
            {
                Console.WriteLine($"Cannot load cargo '{cargoName}'. Exceeds maximum weight.");
                return false;
            }
        }

        public bool UnloadCargo(string cargoName, double weight)
        {
            var cargo = _ship.CargoList.Find(c => c.Name == cargoName && c.Weight == weight);
            if (cargo != null)
            {
                _ship.CargoList.Remove(cargo);
                _ship.CurrentCargoWeight -= weight;
                Console.WriteLine($"Cargo '{cargoName}' with weight {weight} unloaded successfully.");
                return true;
            }
            else
            {
                Console.WriteLine($"Cannot unload cargo '{cargoName}'. It may not be on the ship or the weight is incorrect.");
                return false;
            }
        }

        public void Depart()
        {
            if (_ship.CurrentCargoWeight <= _ship.MaxCargoWeight)
            {
                Console.WriteLine("Ship is departing...");
            }
            else
            {
                Console.WriteLine("Ship cannot depart. Exceeds maximum cargo weight.");
            }
        }

        public void PrintCurrentStatus()
        {
            Console.WriteLine($"Ship '{_ship.Name}' Current Cargo Weight: {_ship.CurrentCargoWeight}/{_ship.MaxCargoWeight}");
            Console.WriteLine("Current cargo list: ");
            foreach (var cargo in _ship.CargoList)
            {
                Console.WriteLine($"- {cargo.Name} ({cargo.Weight} kg)");
            }
        }
    }
}
