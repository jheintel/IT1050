using System;

namespace SubClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Satellite moon = new Satellite("Earth", "Moon");
            ManMadeSat station = new ManMadeSat("Earth", "The ISS", "Nasa");

            moon.Name = "The Moon";

            moon.PrintSystem();
            Console.WriteLine();
            station.PrintSystem();
            Console.ReadKey();
        }
    }
}
