using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dolphin : Mammal
    {
        Mammals specie = Mammals.Dolphin;
        int speed;
        public Dolphin(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Mammal}) that:");

        }
        public void Fly()
        {
            speed = 12;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }


        public void Swim()
        {
            speed = 60;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }


    }
}
