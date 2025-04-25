using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class Chicken : Animal

    {
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Chicken()
        {
        }

        public override required string Name { get; set; }


        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I eat corns");
        }

        public override void Walk()
        {
            Console.WriteLine("I walk like Chicken");
        }

        public override void Speak()
        {
            Console.WriteLine("Kwa Kwa Kwa!!!");
        }

        public  void  RunAway(Cat c)
        {
            Console.WriteLine($"I run away from { c.Name}");
        }
    }
}
