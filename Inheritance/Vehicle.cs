using System;

namespace gary_garage
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} {Name} drives right by you!");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle gently rolls to a stop!");
        }
        public virtual void Turn()
        {
            Console.WriteLine($"The {Name} turned to the right");
        }
    }
}