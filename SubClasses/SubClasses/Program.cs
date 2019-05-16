using System;

namespace SubClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Satellite moon = new Satellite("Earth", "Moon");
            ManMadeSat station = new ManMadeSat("Earth", "The ISS", "Nasa");


            // Object Initializer doesn't call a constructor to set values
            Satellite europa = new Satellite()
            {
                Name = "Europa",
                Primary = "Jupiter"
            };

            moon.Name = "The Moon";

            moon.PrintSystem();
            Console.WriteLine();
            europa.PrintSystem();
            Console.WriteLine();
            station.PrintSystem();
            Console.ReadKey();
        }
    }
}
