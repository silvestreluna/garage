using garage.Vehicle;
using System;

namespace garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.BreakingOrLanding();
            car.DrivingOrFlying();

        }
    }
}
