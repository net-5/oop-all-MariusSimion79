using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Shark : Fish
    {
        Fishes specie = Fishes.Shark;
        int speed;
        public Shark(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Fish}) that:");

        }
        public void Fly()
        {
            speed = 12;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }


        public void Swim()
        {
            speed = 75;
            Console.WriteLine($"     - swim with maximum speed of { speed}Km/h.");
        }

    }

}
