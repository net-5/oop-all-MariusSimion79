using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Insect:Animal
    {
        public enum Insects { Tarantulla, Grasshopper}
        public Insect(string name) : base(name)
        {

        }
    }
}
