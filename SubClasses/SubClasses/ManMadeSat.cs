using System;

namespace SubClasses
{
    class ManMadeSat : Satellite
    {
        public ManMadeSat(string primary, string name, string creator)
        {
            Name = name;
            Primary = primary;
            Creator = creator;
        }

        public string Creator { get; set; }

        public override void PrintSystem()
        {
            base.PrintSystem();
            Console.WriteLine("Created by: " + Creator);
        }
    }
}
