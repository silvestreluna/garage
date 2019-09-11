using System;
using System.Collections.Generic;
using System.Text;

namespace garage.Vehicle
{
    class Aircraft : Vehicle
    {
        public override void BreakingOrLanding()
        {
            Console.WriteLine("This Air plane is landing");
        }

        public override void DrivingOrFlying()
        {
            Console.WriteLine("This air plaing is flying");
        }
    }
}
 