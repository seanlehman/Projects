using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Constructor_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FitnessClasses zoomba = new FitnessClasses("Zoomba", 500);
            FitnessClasses crossfit = new FitnessClasses("Crossfit", 4);
            FitnessClasses boxing = new FitnessClasses("Boxing", 2);

            Console.WriteLine("My favorite class is {0}", boxing.Title);
            Console.ReadLine();




        }
    }
    
    /// <summary>
    /// Pretend that this class is in a separate file
    /// </summary>
    public class FitnessClasses
    {
        //Constructor
        public FitnessClasses(string title, int numberOfStudents)
        {
            this.Title = title;
            this.NumberOfStudents = numberOfStudents;

        }
        //Properties
        public string Title { get; set; }
        public int NumberOfStudents { get; set; }



    }

}

// Constructor Notes:
//  No return Type.
//  Name matches name of class
//    Help set default values
//    Don't alsways need them in the class, but they create safety
