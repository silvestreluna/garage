using System;
using System.Collections.Generic;
using System.Text;

namespace garage.Vehicle
{
    class Car : Vehicle
    {
        public override void BreakingOrLanding()
        {
            Console.WriteLine("The car is breaking");
        }

        public override void DrivingOrFlying()
        {
            Console.WriteLine("The car is driving");
            Console.WriteLine($"The car fuel level is {FuelLevel} and is {Color.Black}");
        }
    }
}
