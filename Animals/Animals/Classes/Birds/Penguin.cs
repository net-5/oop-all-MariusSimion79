using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Penguin : Bird
    {
        Birds specie = Birds.Penguin;
        int speed;
        public Penguin(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Bird}) that:");

        }
        public void Walk()
        {
            speed = 2;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }

        public void Swim()
        {
            speed = 26;
            Console.WriteLine($"     - swim with maximum speed of { speed}Km/h.");
        }

    }
}

