using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public enum Mammals { Bat, Dolphin, Sheep }
    public abstract class Mammal : Animal
    {
        public int Speed { get; set; }
        public Mammal(string name) : base(name)
        {


        }

    }
}
