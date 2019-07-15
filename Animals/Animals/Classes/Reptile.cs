using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public enum Reptiles { Crocodile, Snake}
    public class Reptile:Animal
    {
        public Reptile(string name) : base(name)
        {

        }
    }
}
