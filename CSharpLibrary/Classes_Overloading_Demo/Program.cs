using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Overloading_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals kangaroo = new Animals("Kangaroo");
            Animals kangaroo2 = new Animals ("Kangaroo", "Big One")
            Animals platypus = new Animals("Platypus", "Sea Creature");
        }
    }

    public class Animals
    {
        //Constructor#1
        public Animals(string name)
        {
            this.Name = name;
        }
        // Constructor #2
        public Animals(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        //Constructor #3

        public Animals(string name, string type, int numberOfLegs)
        {
            this.Name = name;
            this.Type = type;
            this.NumberOfLegs = numberOfLegs;
        }


        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public int NumberOfLegs { get; set; }




    }
}
