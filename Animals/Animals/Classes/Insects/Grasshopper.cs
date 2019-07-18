using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Grasshopper : Insect
    {
        Insects specie = Insects.Grasshopper;
        int speed;
        public Grasshopper(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Insect}) that:");

        }
        public void Fly()
        {
            speed = 26;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }
        public void Walk()
        {
            speed = 6;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }

    }
}
