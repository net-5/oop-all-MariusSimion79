using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Sheep : Mammal
    {
        Mammals specie = Mammals.Sheep;
        int speed;
        public Sheep(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Mammal}) that:");

        }

        public void Walk()
        {
            speed = 20;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }


    }
}
