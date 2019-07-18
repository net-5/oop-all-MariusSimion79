using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tarantulla : Insect
    {
        Insects specie = Insects.Tarantulla;
        int speed;
        public Tarantulla(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Insect}) that:");

        }

        public void Walk()
        {
            speed = 10;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }



    }
}
