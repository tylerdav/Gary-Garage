using System;

namespace gary_garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Turn()
        {
            Console.WriteLine($"The {Name} turned to the Left");
        }
    }
}