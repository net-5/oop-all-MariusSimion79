using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public enum Birds { Canary, Penguin }
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {

        }

    }
}
