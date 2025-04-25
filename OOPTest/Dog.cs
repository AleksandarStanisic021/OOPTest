using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class Dog : Animal

    {
        private string name;
        private int age;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Dog()
        {
        }

        public override required string Name { get; set; }


        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I eat bones");
        }

        public override void Walk()
        {
            Console.WriteLine("I'm strong dog");
        }

        public override void Speak()
        {
            Console.WriteLine("wuff wuuf!!!");
        }

        public void RunAway(Animal a)
        {
            Console.WriteLine($"I run away from nothing");
        }

        public  void Hunt(Cat c)
        {
            Console.WriteLine($"I hunt cute {c.Name}");
        }
    }
}

