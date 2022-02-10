using System;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Satellite sun = new Satellite("Sagittarius A *", "Sun");

            ManMadeSat station = new ManMadeSat("Earth", "The ISS", "Nasa");
            Satellite mercury = new Satellite(sun, "Mercury");
            Satellite venus = new Satellite(sun, "Venus");
            Satellite earth = new Satellite(sun, "Earth");
            Satellite mars = new Satellite(sun, "Mars");
            Satellite jupiter = new Satellite(sun, "Jupiter");

            Satellite moon = new Satellite(earth , "Moon");

            List<Satellite> MajorBodies = new List<Satellite>()
            {
                mercury,
                venus,
                earth,
                mars
            };

            MajorBodies.Add(jupiter);

            foreach (var el in MajorBodies)
                el.PrintSystem();

            // Object Initializer doesn't call a constructor to set values
            Satellite europa = new Satellite()
            {
                Name = "Europa",
                PrimaryName = "Jupiter",
                PrimarySat = jupiter
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
