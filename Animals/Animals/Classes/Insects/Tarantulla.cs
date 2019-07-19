using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tarantulla : Insect, IWalk
    {
        Insects specie = Insects.Tarantulla;
        private int walkSpeed;
        public int WalkSpeed { get; set; }
        public Tarantulla(string name, int walkSpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Insect}) that:");
            WalkSpeed = walkSpeed;
        }

        public void Walk()
        {
            
            Console.WriteLine($"     - walk with maximum speed of { WalkSpeed}Km/h.");
        }



    }
}
