using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Snake : Reptile, ICrawl
    {
        Reptiles specie = Reptiles.Snake;
        private int crawlSpeed;
        public int CrawlSpeed { get; set; }
        public Snake(string name, int crawlSpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Reptile}) that:");
            CrawlSpeed = crawlSpeed;
        }

        public void Crawl()
        {
            
            Console.WriteLine($"     - crawl with maximum speed of {CrawlSpeed}Km/h.");
        }
    }
}
