using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Bath : Mammal
    {
        Mammals specie = Mammals.Bath;
        int speed;
        public Bath(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Mammal}) that:");

        }
        public void Fly()
        {
            speed = 120;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }
        public void Walk()
        {
            speed = 2;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }


    }
}