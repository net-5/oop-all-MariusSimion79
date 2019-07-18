using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Snake : Reptile
    {
        Reptiles specie = Reptiles.Snake;
        int speed;
        public Snake(string name) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Reptile}) that:");

        }

        public void Crawl()
        {
            speed = 15;
            Console.WriteLine($"     - crawl with maximum speed of { speed}Km/h.");
        }
    }
}
