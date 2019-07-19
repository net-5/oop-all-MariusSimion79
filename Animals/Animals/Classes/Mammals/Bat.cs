using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Bat : Mammal, IFly, IWalk
    {
        Mammals specie = Mammals.Bat;
        private int flySpeed;
        private int walkSpeed;
        public int FlySpeed { get; set; }
        public int WalkSpeed { get; set; }
        public Bat(string name, int flySpeed, int walkSpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Mammal}) that:");
            FlySpeed = flySpeed;
            WalkSpeed = walkSpeed;
        }
        public void Fly()
        {
            
            Console.WriteLine($"     - fly with maximum speed of { FlySpeed}Km/h.");
        }
        public void Walk()
        {
            
            Console.WriteLine($"     - walk with maximum speed of { WalkSpeed}Km/h.");
        }


    }
}