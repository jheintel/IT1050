using System;

namespace SubClasses
{
    class Satellite
    {
        public string Primary { get; set; }
        public string Name { get; set; }

        public Satellite() { }

        public Satellite(string primary, string name)
        {
            Primary = primary;
            Name = name;
        }

        public virtual void PrintSystem()
        {
            Console.WriteLine(Name + " orbits: " + Primary);
        }

    }
}
