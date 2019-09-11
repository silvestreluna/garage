using System;
using System.Collections.Generic;
using System.Text;

namespace garage.Vehicle
{
    class Watercraft : Vehicle
    {
        public override void BreakingOrLanding()
        {
            Console.WriteLine("The boat is landing.");
        }

        public override void DrivingOrFlying()
        {
            Console.WriteLine("The boat is being driving.");
        }
    }
}
