using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dolphin : Mammal
    {
        string specie = Mammals.Dolphin.ToString();
        int speed;
        public Dolphin(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Mammal}) that:");

        }
        public override void Fly()
        {
            speed = 12;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }
        public override void Walk()
        {
            Console.WriteLine($"     - can`t walk.");
        }

        public override void Swim()
        {
            speed = 60;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }
        public override void Crawl()
        {
            Console.WriteLine($"     - can`t crawl.");
        }

    }
}
