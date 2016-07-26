using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car angiesCar = new Car(); //an instance of the class
            angiesCar.Make = "Toyota";
            angiesCar.Year = 2007;
            angiesCar.PrintYear();
            Console.WriteLine("Angie owns a {0} {1}", angiesCar.Year, angiesCar.Make);


            Car paulsCar = new Car();
            paulsCar.Make = "Masarati";
            paulsCar.Year = 2016;
            paulsCar.PrintYear();

            Car jennifersCar = new Car();
            Car zachsCar = new Car();
            Car collinsCar = new Car();
            Console.ReadLine();  //Has to be at the bottom


        }
    }
    public class Car
    {
        // Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsAutomatic { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }


        //Method
        public void PrintYear()
        {
            Console.WriteLine("The year is {0}", Year);
        }

    }




}
