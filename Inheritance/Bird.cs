using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            Skin = "feathers";
            BeakLength = 1;
            Toes = 3;
            Flight = true;
            Motion = "fly";
            Diet = "bugs";
            Noise = "chirp";
        }
                
        public bool Flight { get; set; }
        public string Noise { get; set; }
        public double BeakLength { get; set; }
        public int Toes { get; }

    }
}
