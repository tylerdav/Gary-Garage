using System;

namespace gary_garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"A {Name} drives past... Silently.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {Name} stops near you... So quiet.");
        }
    }
}