using System;

namespace SolarSystem
{
    class Satellite
    {
        public string PrimaryName { get; set; }
        public string Name { get; set; }
        public Satellite PrimarySat { get; set; }

        public Satellite() { }

        public Satellite(string primary, string name)
        {
            PrimaryName = primary;
            Name = name;
        }

        public Satellite(Satellite primary, string name)
        {
            PrimarySat = primary;
            PrimaryName = primary.Name;
            Name = name;
        }

        public virtual void PrintSystem()
        {
            Console.WriteLine(Name + " orbits: " + PrimaryName);
        }

    }
}
