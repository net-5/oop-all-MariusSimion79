using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Crocodile : Reptile
    {
        Reptiles specie = Reptiles.Snake;
        int speed;
        public Crocodile(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Reptile}) that:");

        }

        public void Walk()
        {
            speed = 5;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }

        public void Swim()
        {
            speed = 30;
            Console.WriteLine($"     - swim with maximum speed of { speed}Km/h.");
        }

    }
}
