using System;
using ShippingApp.Logic;
using ShippingApp.Models;

namespace ShippingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship myShip = new Ship("HMS Endeavour", 1000);
            ShipLogic operations = new ShipLogic(myShip);

            operations.LoadCargo("Iron", 500);
            operations.LoadCargo("Coal", 300);
            operations.PrintCurrentStatus();

            operations.UnloadCargo("Coal", 300);
            operations.PrintCurrentStatus();

            operations.Depart();
        }
    }
}
