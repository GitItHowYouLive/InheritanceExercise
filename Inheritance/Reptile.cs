using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
            Aggressive = true;
            Endangered = false;
            Venomous = true;
            Origin = "Unknown";
            Motion = "Walk";
            Skin = "scales";
            Legs = 4;
        }
        public bool Aggressive { get; set; }
        public bool Endangered { get; set; }
        public bool Venomous { get; set; }
        public string Origin { get; set; }

    }
}
