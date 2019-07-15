using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Penguin : Bird
    {
        string specie = Birds.Penguin.ToString();
        int speed;
        public Penguin(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Bird}) that:");

        }
        public override void Fly()
        {
            Console.WriteLine($"     - can`t fly.");
        }
        public override void Walk()
        {
            speed = 2;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }

        public override void Swim()
        {
            speed = 26;
            Console.WriteLine($"     - swim with maximum speed of { speed}Km/h.");
        }
        public override void Crawl()
        {
            Console.WriteLine($"     - can`t crawl.");
        }
    }
}
