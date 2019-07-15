using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Grasshopper:Insect
    {
        string specie = Insects.Grasshopper.ToString();
        int speed;
        public Grasshopper(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Insect}) that:");

        }
        public override void Fly()
        {
            speed = 26;
            Console.WriteLine($"     - fly with maximum speed of { speed}Km/h.");
        }
        public override void Walk()
        {
            speed =6;
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
