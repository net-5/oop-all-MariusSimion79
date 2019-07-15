using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Sheep : Mammal
    {
        string specie = Mammals.Sheep.ToString();
        int speed;
        public Sheep(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Mammal}) that:");

        }
        public override void Fly()
        {
            Console.WriteLine($"     - can`t fly.");
        }
        public override void Walk()
        {
            speed = 20;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }

        public override void Swim()
        {
            Console.WriteLine($"     - can`t swim.");
        }
        public override void Crawl()
        {
            Console.WriteLine($"     - can`t crawl.");
        }
    }
}
