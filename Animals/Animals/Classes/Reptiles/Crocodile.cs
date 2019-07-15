using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Crocodile:Reptile
    {
        string specie = Reptiles.Snake.ToString();
        int speed;
        public Crocodile(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Reptile}) that:");

        }
        public override void Fly()
        {
            Console.WriteLine($"     - can`t fly.");
        }
        public override void Walk()
        {
            speed = 5;
            Console.WriteLine($"     - walk with maximum speed of { speed}Km/h.");
        }

        public override void Swim()
        {
            speed = 30;
            Console.WriteLine($"     - swim with maximum speed of { speed}Km/h.");
        }
        public override void Crawl()
        {
            Console.WriteLine($"     - can`t fly.");
        }
    }
}
