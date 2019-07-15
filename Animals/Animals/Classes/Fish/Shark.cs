using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Shark : Fish
    {
        string specie = Fishes.Shark.ToString();
        int speed;
        public Shark(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Fish}) that:");

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
            speed = 75;
            Console.WriteLine($"     - swim with maximum speed of { speed}Km/h.");
        }
        public override void Crawl()
        {
            Console.WriteLine($"     - can`t crawl.");
        }
    }

}
