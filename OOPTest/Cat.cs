using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class Cat : Animal

    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Cat()
        {
        }

        public override required string Name { get; set; }


        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I eat meat");
        }

        public override void Walk()
        {
            Console.WriteLine("I'm nimble cat");
        }

        public override void Speak()
        {
            Console.WriteLine("Mijao!!!");
        }

        public  void RunAway(Dog d)
        {
            Console.WriteLine($"I run away from {d.Name}");
        }

        public  void Hunt(Chicken c)
        {
            Console.WriteLine($"I hunt {c.Name}");
        }
    }
}
