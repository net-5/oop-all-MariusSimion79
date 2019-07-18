using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Canary : Bird
    {
        Birds specie = Birds.Canary;
        int speed;
        public Canary(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Bird}) that:");

        }
        public void Fly()
        {
            speed = 60;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }
        public void Walk()
        {
            speed = 2;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }


    }
}
