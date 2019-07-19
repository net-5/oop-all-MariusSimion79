using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Clownfish : Fish, ISwim
    {
        Fishes specie = Fishes.Clownfish;
        private int swimSpeed;
        public int SwimSpeed { get; set; }
        public Clownfish(string name, int swimSpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Fish}) that:");
            SwimSpeed = swimSpeed;
        }

        public void Swim()
        {
            
            Console.WriteLine($"     - swim with maximum speed of { SwimSpeed}Km/h.");
        }

    }
}
