using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Clownfish : Fish
    {
        Fishes specie = Fishes.Clownfish;
        int speed;
        public Clownfish(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Fish}) that:");

        }

        public void Swim()
        {
            speed = 75;
            Console.WriteLine($"     - swim with maximum speed of { speed}Km/h.");
        }

    }
}
