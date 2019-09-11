using System;
using System.Collections.Generic;
using System.Text;

namespace garage.Vehicle
{
    abstract class Vehicle
    {
        public int FuelLevel { get; set; }
        public Color Color { get; set; }
        public int NumberOfPassengerOccupancy { get; set; }

        public void Refueling()
        {
            Console.WriteLine("Refueling");
        }
        public abstract void DrivingOrFlying();
        public abstract void BreakingOrLanding();

    }
    enum Color
    {
        Red,
        Green,
        Black,
        White,
    }
}
