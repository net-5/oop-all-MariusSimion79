using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tarantulla:Insect
    {
        string specie = Insects.Tarantulla.ToString();
        int speed;
        public Tarantulla(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Insect}) that:");

        }
        public override void Fly()
        {
            Console.WriteLine($"     - can`t fly.");
        }
        public override void Walk()
        {
            speed = 10;
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
