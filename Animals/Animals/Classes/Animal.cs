using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public enum AnimalTypes { Bird, Fish, Insect, Reptile, Mammal }
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        /*
                public virtual void Fly()
                {
                    Console.WriteLine("This animal can fly.");
                }
                public virtual void Walk()
                {
                    Console.WriteLine("This animal can walk.");
                }
                public virtual void Swim()
                {
                    Console.WriteLine("This animal can swim.");
                }
                public virtual void Crawl()
                {
                    Console.WriteLine("This animal can crawl.");
                }
                */
    }
}
