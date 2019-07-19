using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Crocodile : Reptile, IWalk, ISwim
    {
        Reptiles specie = Reptiles.Crocodile;
        private int walkSpeed;
        private int swimSpeed;
        public int WalkSpeed { get; set; }
        public int SwimSpeed { get; set; }

        public Crocodile(string name,int walkSpeed, int swimSpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Reptile}) that:");
            WalkSpeed = walkSpeed;
            SwimSpeed = swimSpeed;
        }

        public void Walk()
        {
            
            Console.WriteLine($"     - walk with maximum speed of { WalkSpeed}Km/h.");
        }

        public void Swim()
        {
            
            Console.WriteLine($"     - swim with maximum speed of { SwimSpeed}Km/h.");
        }

    }
}
