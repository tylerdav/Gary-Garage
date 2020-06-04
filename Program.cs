using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var fxs = new Zero();
            fxs.Name = "Zero";
            fxs.MainColor = "Black";
            fxs.MaximumOccupancy = 2;

            var modelS = new Tesla();
            modelS.Name = "Tesla";
            modelS.MainColor = "Red";
            modelS.MaximumOccupancy = 2;

            var mx410 = new Cessna();
            mx410.Name = "Cessna";
            mx410.MainColor = "White";
            mx410.MaximumOccupancy = 2;

            var pickup = new Ram();
            pickup.Name = "Ram";
            pickup.MainColor = "Orange";
            pickup.MaximumOccupancy = 2;

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            Console.WriteLine("--------------------");

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            Console.WriteLine("--------------------");

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            Console.WriteLine("--------------------");

            pickup.Drive();
            pickup.Turn();
            pickup.Stop();

            Console.WriteLine("--------------------");
        }
    }
}