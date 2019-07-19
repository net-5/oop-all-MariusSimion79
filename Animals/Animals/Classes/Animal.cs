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

    }
}
