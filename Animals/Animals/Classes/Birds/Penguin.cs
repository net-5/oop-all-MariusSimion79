using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Penguin : Bird, ISwim, IWalk
    {
        Birds specie = Birds.Penguin;
       private int swimSpeed;
        private int walkSpeed;
        public int SwimSpeed { get; set; }
        public int WalkSpeed { get; set; }
        public Penguin(string name, int swimSpeed, int walkSpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Bird}) that:");
            SwimSpeed = swimSpeed;
            WalkSpeed = walkSpeed;
        }
        public void Walk()
        {
            
            Console.WriteLine($"     - walk with maximum speed of {SwimSpeed}Km/h.");
        }

        public void Swim()
        {
            
            Console.WriteLine($"     - swim with maximum speed of { WalkSpeed}Km/h.");
        }

    }
}

