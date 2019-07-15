using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Snake:Reptile
    {
        string specie = Reptiles.Snake.ToString();
        int speed;
        public Snake(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Reptile}) that:");

        }
        public override void Fly()
        {
            Console.WriteLine($"     - can`t fly.");
        }
        public override void Walk()
        {
            Console.WriteLine($"     - can`t walk.");
        }

        public override void Swim()
        {
            Console.WriteLine($"     - can`t swim.");
        }
        public override void Crawl()
        {
            speed = 15;
            Console.WriteLine($"     - crawl with maximum speed of { speed}Km/h.");
        }
    }
}
