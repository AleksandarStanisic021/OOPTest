using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public abstract class Animal
    {
        public Animal() { }
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract void Walk();
        public abstract void Eat();
        public abstract void Speak();
    }
}
