using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Shark : Fish, ISwim, IFly
    {
        Fishes specie = Fishes.Shark;
       private  int swimSpeed;
        private int flySpeed;
        public int SwimSpeed { get; set; }
        public int FlySpeed { get; set; }
        public Shark(string name, int swimSpeed, int flySpeed) : base(name)
        {
            Console.WriteLine($"{ this.Name} is a {specie} ({AnimalTypes.Fish}) that:");
            SwimSpeed = swimSpeed;
            FlySpeed = flySpeed;
        }
        public void Fly()
        {
            
            Console.WriteLine($"     - fly with maximum speed of { FlySpeed}Km/h.");
        }


        public void Swim()
        {
            
            Console.WriteLine($"     - swim with maximum speed of { SwimSpeed}Km/h.");
        }

    }

}
