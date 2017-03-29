using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassHomework
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car oldCar = new Car();


            myCar.Make = "Hyundai";
            myCar.Model = "Tiburon";
            myCar.Year = 2008;
            myCar.Color = "Black";


            oldCar.Make = "Chevrolet";
            oldCar.Model = "Trail Blazer";
            oldCar.Year = 2004;
            oldCar.Color = "White";


            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");
            Console.WriteLine($"{oldCar.Make} {oldCar.Model} {oldCar.Year} {oldCar.Color}");
        }
 
    }
}
