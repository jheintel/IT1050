﻿using System;

namespace SolarSystem
{
    class ManMadeSat : Satellite
    {
        public ManMadeSat(string primary, string name, string creator)
        {
            Name = name;
            PrimaryName = primary;
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
