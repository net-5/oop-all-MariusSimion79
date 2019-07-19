using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Sheep : Mammal, IWalk
    {
        Mammals specie = Mammals.Sheep;
        private int walkSpeed;
        public int WalkSpeed { get; set; }
        public Sheep(string name,int walkSpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Mammal}) that:");
            WalkSpeed = walkSpeed;
        }

        public void Walk()
        {
            
            Console.WriteLine($"     - walk with maximum speed of {WalkSpeed}Km/h.");
        }


    }
}
