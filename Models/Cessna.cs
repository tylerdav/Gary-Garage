using System;

namespace gary_garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"You See the {Name} fly right over You. Wow..");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} {Name} rolls to a stop after rolling a mile down the runway.");
        }
    }
}