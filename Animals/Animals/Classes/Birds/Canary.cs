using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Canary : Bird
    {
        string specie = Birds.Canary.ToString();
        int speed;
        public Canary(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Bird}) that:");

        }
        public override void Fly()
        {
            speed = 60;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }
        public override void Walk()
        {
            speed = 2;
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
