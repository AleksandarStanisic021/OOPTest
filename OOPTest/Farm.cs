using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    public class Farm
    {
        List<Animal> list;
        public Farm() {

            list = new List<Animal>();
        }
        public Farm(string name) 
        {
            Name = name;
            list = new List<Animal>();
        }

        public string Name  { get; set; }
        public List<Animal> List { get {
                return list; } }
        public void Add(Animal a)
        {
            list.Add(a);
        }
 
        public void ReadList()
        {
            Console.WriteLine($"Farm Details {Name}");
            Console.WriteLine("**************************");
            foreach (Animal a in list)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
